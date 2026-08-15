using System.Linq;
using Machine.Specifications;

namespace Elders.Iso3166.Tests
{
    [Subject(typeof(EconomicZone))]
    class When_getting__EconomicZone__by_code
    {
        static EconomicZone zone;

        Because of = () => zone = new EconomicZone("EU");

        It should_have_the_code = () => zone.Code.ShouldEqual("EU");

        It should_have_the_name = () => zone.Name.ShouldEqual("European Union");

        It should_have_the_type = () => zone.Type.ShouldEqual(EconomicZoneType.EconomicUnion);

        It should_be_equal_to_the_static_field = () => zone.ShouldEqual(EconomicZone.EU);
    }

    [Subject(typeof(EconomicZone))]
    class When_getting__EconomicZone__by_code_in_any_casing
    {
        static EconomicZone zone;

        Because of = () => zone = new EconomicZone("eu");

        It should_resolve_the_same_zone = () => zone.ShouldEqual(EconomicZone.EU);

        It should_report_the_canonical_casing = () => zone.Code.ShouldEqual("EU");
    }

    [Subject(typeof(EconomicZone))]
    class When_the__EconomicZone__code_is_unknown
    {
        static System.Exception exception;

        Because of = () => exception = Catch.Exception(() => new EconomicZone("NOPE"));

        It should_throw = () => exception.ShouldBeOfExactType<System.ArgumentException>();
    }

    [Subject(typeof(EconomicZone))]
    class When_inspecting_the_European_Union
    {
        It should_have_27_members = () => EconomicZone.EU.Members.Count.ShouldEqual(27);

        It should_contain_Bulgaria = () => EconomicZone.EU.Contains(Country.BG).ShouldBeTrue();

        It should_not_contain_the_United_Kingdom = () => EconomicZone.EU.Contains(Country.GB).ShouldBeFalse();

        It should_not_contain_Switzerland = () => EconomicZone.EU.Contains(Country.CH).ShouldBeFalse();
    }

    [Subject(typeof(EconomicZone))]
    class When_inspecting_the_euro_area
    {
        It should_have_21_members = () => EconomicZone.EA.Members.Count.ShouldEqual(21);

        It should_be_a_monetary_union = () => EconomicZone.EA.Type.ShouldEqual(EconomicZoneType.MonetaryUnion);

        It should_contain_Bulgaria = () => EconomicZone.EA.Contains(Country.BG).ShouldBeTrue();

        It should_contain_Croatia = () => EconomicZone.EA.Contains(Country.HR).ShouldBeTrue();

        It should_not_contain_Sweden = () => EconomicZone.EA.Contains(Country.SE).ShouldBeFalse();

        It should_not_contain_Poland = () => EconomicZone.EA.Contains(Country.PL).ShouldBeFalse();

        It should_be_a_subset_of_the_European_Union =
            () => EconomicZone.EA.Members.All(x => EconomicZone.EU.Contains(x)).ShouldBeTrue();
    }

    [Subject(typeof(EconomicZone))]
    class When_inspecting_the_European_Economic_Area
    {
        It should_have_30_members = () => EconomicZone.EEA.Members.Count.ShouldEqual(30);

        It should_contain_Norway = () => EconomicZone.EEA.Contains(Country.NO).ShouldBeTrue();

        It should_not_contain_Switzerland = () => EconomicZone.EEA.Contains(Country.CH).ShouldBeFalse();

        It should_contain_every_European_Union_member =
            () => EconomicZone.EU.Members.All(x => EconomicZone.EEA.Contains(x)).ShouldBeTrue();
    }

    [Subject(typeof(EconomicZone))]
    class When_inspecting_the_European_Free_Trade_Association
    {
        It should_have_4_members = () => EconomicZone.EFTA.Members.Count.ShouldEqual(4);

        It should_contain_Switzerland = () => EconomicZone.EFTA.Contains(Country.CH).ShouldBeTrue();

        It should_share_no_members_with_the_European_Union =
            () => EconomicZone.EFTA.Members.Any(x => EconomicZone.EU.Contains(x)).ShouldBeFalse();
    }

    [Subject(typeof(EconomicZone))]
    class When_inspecting_the_Schengen_Area
    {
        It should_have_29_members = () => EconomicZone.SCHENGEN.Members.Count.ShouldEqual(29);

        It should_be_a_free_movement_area =
            () => EconomicZone.SCHENGEN.Type.ShouldEqual(EconomicZoneType.FreeMovementArea);

        It should_contain_Bulgaria = () => EconomicZone.SCHENGEN.Contains(Country.BG).ShouldBeTrue();

        It should_contain_Romania = () => EconomicZone.SCHENGEN.Contains(Country.RO).ShouldBeTrue();

        It should_not_contain_Ireland = () => EconomicZone.SCHENGEN.Contains(Country.IE).ShouldBeFalse();

        It should_not_contain_Cyprus = () => EconomicZone.SCHENGEN.Contains(Country.CY).ShouldBeFalse();

        It should_contain_Switzerland = () => EconomicZone.SCHENGEN.Contains(Country.CH).ShouldBeTrue();

        It should_contain_Norway = () => EconomicZone.SCHENGEN.Contains(Country.NO).ShouldBeTrue();
    }

    [Subject(typeof(EconomicZone))]
    class When_inspecting_the_non_European_zones
    {
        It should_have_3_USMCA_members = () => EconomicZone.USMCA.Members.Count.ShouldEqual(3);

        It should_contain_Mexico_in_USMCA = () => EconomicZone.USMCA.Contains(Country.MX).ShouldBeTrue();

        It should_have_6_GCC_members = () => EconomicZone.GCC.Members.Count.ShouldEqual(6);

        It should_contain_Saudi_Arabia_in_GCC = () => EconomicZone.GCC.Contains(Country.SA).ShouldBeTrue();

        It should_have_7_G7_members = () => EconomicZone.G7.Members.Count.ShouldEqual(7);

        It should_contain_Japan_in_G7 = () => EconomicZone.G7.Contains(Country.JP).ShouldBeTrue();

        It should_type_the_G7_as_a_global_group =
            () => EconomicZone.G7.Type.ShouldEqual(EconomicZoneType.GlobalEconomicGroup);
    }

    [Subject(typeof(Country))]
    class When_asking_a__Country__for_its_zones
    {
        It should_report_membership = () => Country.BE.IsIn(EconomicZone.EU).ShouldBeTrue();

        It should_report_non_membership = () => Country.US.IsIn(EconomicZone.EU).ShouldBeFalse();

        It should_list_every_zone_a_country_belongs_to =
            () => Country.DE.Zones.Select(x => x.Code).OrderBy(x => x)
                .ShouldContain("EA", "EEA", "EU", "G7", "SCHENGEN");

        It should_list_nothing_for_a_country_in_no_zone =
            () => Country.JP.Zones.Select(x => x.Code).ShouldContainOnly("G7");
    }

    [Subject(typeof(EconomicZone))]
    class When_enumerating_all_zones
    {
        It should_return_every_zone = () => EconomicZone.GetAllZones().Count().ShouldEqual(8);

        It should_resolve_each_one = () => EconomicZone.GetAllZones().All(x => x.Members.Count > 0).ShouldBeTrue();

        It should_name_each_one = () =>
            EconomicZone.GetAllZones().All(x => string.IsNullOrWhiteSpace(x.Name) == false).ShouldBeTrue();
    }

    [Subject(typeof(EconomicZone))]
    class When_parsing_an__EconomicZone
    {
        It should_succeed_for_a_known_code = () =>
        {
            EconomicZone.TryParse("EEA", out var zone).ShouldBeTrue();
            zone.ShouldEqual(EconomicZone.EEA);
        };

        It should_fail_for_an_unknown_code = () => EconomicZone.TryParse("XX", out _).ShouldBeFalse();

        It should_fail_for_nothing = () => EconomicZone.TryParse(null, out _).ShouldBeFalse();
    }

    [Subject(typeof(EconomicZone))]
    class When_serializing_an__EconomicZone
    {
        static string json;

        Because of = () => json = new TestJsonSerializer().Serialize(EconomicZone.EU);

        It should_be_equal = () => json.ShouldEqual("""{"$type":"Elders.Iso3166.EconomicZone, Elders.CountryCodes","0":"EU"}""");
    }

    [Subject(typeof(EconomicZone))]
    class When_deserializing_an__EconomicZone
    {
        static EconomicZone zone;

        Because of = () => zone = new TestJsonSerializer().Deserialize<EconomicZone>("""{"$type":"Elders.Iso3166.EconomicZone, Elders.CountryCodes","0":"EEA"}""");

        It should_be_equal = () => zone.ShouldEqual(EconomicZone.EEA);

        It should_resolve_its_members = () => zone.Members.Count.ShouldEqual(30);
    }

    [Subject(typeof(EconomicZone))]
    class When_deserializing_an__EconomicZone__stored_in_another_casing
    {
        static EconomicZone zone;

        Because of = () => zone = new TestJsonSerializer().Deserialize<EconomicZone>("""{"$type":"Elders.Iso3166.EconomicZone, Elders.CountryCodes","0":"eu"}""");

        It should_be_equal = () => zone.ShouldEqual(EconomicZone.EU);

        It should_resolve_its_name = () => zone.Name.ShouldEqual("European Union");

        It should_hash_the_same = () => zone.GetHashCode().ShouldEqual(EconomicZone.EU.GetHashCode());
    }

    [Subject(typeof(EconomicZone))]
    class When_serializing_all_zones
    {
        static EconomicZone[] zones;

        Because of = () =>
        {
            var serializer = new TestJsonSerializer();
            var json = serializer.Serialize(EconomicZone.GetAllZones().ToArray());
            zones = serializer.Deserialize<EconomicZone[]>(json);
        };

        It should_be_equal = () => zones.ShouldEqual(EconomicZone.GetAllZones().ToArray());
    }
}
