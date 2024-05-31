using System.Linq;
using Machine.Specifications;

namespace Elders.Iso3166.Tests
{
    [Subject(typeof(Country))]
    public class CountryTests
    {
        const int TOTAL_NUMBER_OF_COUNTRIES = 249;

        static Country country1, country2, country4;
        static bool isEqual;
        static bool isTrue;
        static Country usCountry;

        Establish context = () =>
        {
            country1 = new Country(248);
            country2 = new Country(248);
            country4 = new Country(004);
        };

        class when_building_country_by_numeric_code
        {
            Because of = () => usCountry = new Country(840);

            It should_have_country_code = () => usCountry.NumericCode.ShouldEqual(840);
            It should_have_name = () => usCountry.Name.ShouldEqual("United States");
            It should_have_two_letter_code = () => usCountry.TwoLetterCode.ShouldEqual("US");
            It should_have_three_letter_code = () => usCountry.ThreeLetterCode.ShouldEqual("USA");
        }

        class when_country_is__Avghanistan__
        {
            Because of = () => country4.Equals(Country.AF);

            It should_have_same_name = () => country4.Name.ShouldEqual(Country.AF.Name);
            It should_have_same_two_letter_code = () => country4.TwoLetterCode.ShouldEqual(Country.AF.TwoLetterCode);
            It should_have_same_three_letter_code = () => country4.ThreeLetterCode.ShouldEqual(Country.AF.ThreeLetterCode);
            It should_have_same_country_code = () => country4.NumericCode.ShouldEqual(Country.AF.NumericCode);
        }

        class when_countries_are_equal_v1
        {
            Because of = () => isEqual = country1.Equals(country2);

            It should_be_equal = () => isEqual.ShouldBeTrue();
        }

        class when_countries_are_not_equal_v1
        {
            Because of = () => isEqual = country1.Equals(country4);

            It should_not_be_equal = () => isEqual.ShouldBeFalse();
        }

        class when_countries_are_equal_v2
        {
            Because of = () => isEqual = country1 == country2;

            It should_be_equal = () => isEqual.ShouldBeTrue();
        }

        class when_countries_are_not_equal_v2
        {
            Because of = () => isEqual = country1 != country4;

            It should_not_be_equal = () => isEqual.ShouldBeTrue();
        }

        class total_number_of_countries
        {
            Because of = () => isTrue = TOTAL_NUMBER_OF_COUNTRIES == Country.GetAllCountries().Count();

            It should_be_true = () => isTrue.ShouldBeTrue();
        }

        class when_serializing_country
        {
            static string json;
            Because of = () =>
            {
                var serializer = new TestJsonSerializer();
                json = serializer.Serialize(Country.BG);
            };

            It should_be_equal = () => json.ShouldEqual("""{"$type":"Elders.Iso3166.Country, Elders.CountryCodes","0":100}""");
        }

        class when_deserializing_country
        {
            static Country us;
            Because of = () =>
            {
                var serializer = new TestJsonSerializer();
                us = serializer.Deserialize<Country>("""{"$type":"Elders.Iso3166.Country, Elders.CountryCodes","0":840}""");
            };

            It should_be_equal = () => us.ShouldEqual(Country.US);
        }
    }
}
