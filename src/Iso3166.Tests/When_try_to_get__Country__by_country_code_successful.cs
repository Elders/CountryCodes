using Machine.Specifications;

namespace Elders.Iso3166.Tests
{
    [Subject(typeof(Country))]
    class When_try_to_get__Country__by_country_code_successful
    {
        static Country country;

        Because of = () => country = new Country("US");

        It should_have_correct_numeric_code = () => country.NumericCode.ShouldEqual(840);

        It should_be_equal_to_countryUS = () => country.ShouldEqual(Country.US);
    }
}
