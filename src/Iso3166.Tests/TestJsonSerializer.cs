using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Elders.Iso3166.Tests
{
    public class TestJsonSerializer
    {
        readonly JsonSerializer inner;

        public TestJsonSerializer()
        {
            var serializerSettings = new JsonSerializerSettings();
            serializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;
            serializerSettings.DateFormatHandling = DateFormatHandling.IsoDateFormat;
            serializerSettings.ContractResolver = new DataMemberContractResolver();
            serializerSettings.TypeNameHandling = TypeNameHandling.Objects;
            serializerSettings.TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple;
            serializerSettings.Formatting = Formatting.None;
            serializerSettings.ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor;
            inner = JsonSerializer.Create(serializerSettings);
        }

        public string Serialize(object obj)
        {
            using var sw = new StringWriter(CultureInfo.InvariantCulture);
            using var tw = new JsonTextWriter(sw);

            inner.Serialize(tw, obj);
            return sw.ToString();
        }

        public T Deserialize<T>(string json)
        {
            using var reader = new JsonTextReader(new StringReader(json));

            return inner.Deserialize<T>(reader);
        }

        class DataMemberContractResolver : DefaultContractResolver
        {
            protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
            {
                JsonProperty customMember = base.CreateProperty(member, memberSerialization);
                if (member.CustomAttributes.Any(x => x.AttributeType == typeof(DataMemberAttribute)))
                    customMember.PropertyName = customMember.Order.ToString();

                if (!customMember.Writable)
                {
                    var property = member as PropertyInfo;
                    if (property != null)
                    {
                        var hasPrivateSetter = property.GetSetMethod(true) != null;
                        customMember.Writable = hasPrivateSetter;
                    }
                }

                return customMember;
            }

            protected override JsonContract CreateContract(Type objectType)
            {
                if (objectType.GetInterfaces().Any(i => i == typeof(IDictionary) ||
                    (i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IDictionary<,>))))
                {
                    return base.CreateArrayContract(objectType);
                }

                return base.CreateContract(objectType);
            }
        }
    }
}
