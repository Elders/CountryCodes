using Machine.Specifications;
using System;

namespace Elders.Iso3166.Tests
{
    [Subject(typeof(Country))]
    class When_try_to_get__Country__by_country_code__not_successful
    {
        static Exception exception;

        Because of = () => exception = Catch.Exception(() => new Country("XX"));

        It should_have_correct_numeric_code = () => exception.ShouldBeOfExactType<ArgumentException>();
    }
}
