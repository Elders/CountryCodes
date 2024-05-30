using Machine.Specifications;

namespace Elders.Iso3166.Tests
{
    [Subject(typeof(Subdivision))]
    public class SubdivisionTests
    {
        const int NUMBER_OF_REGIONS_IN_US = 57;

        static Subdivision subdivisionUS_AL1, subdivisionUS_AL2, subdivisionUS_AS;
        static bool isEqual;
        static Subdivision alabama;

        Establish context = () =>
        {
            subdivisionUS_AL1 = new Subdivision("US-AL");
            subdivisionUS_AL2 = new Subdivision("US-AL");
            subdivisionUS_AS = new Subdivision("US-AS");
        };

        class when_subdivision_is__Alabama__
        {
            Because of = () => alabama = new Subdivision("US-AL");

            It should_have_name = () => alabama.Name.ShouldEqual("Alabama");

            It should_have_country_code = () => alabama.Code.ShouldEqual("US-AL");
        }

        class when_subdivisions_are_equal_v1
        {
            Because of = () => isEqual = subdivisionUS_AL1.Equals(subdivisionUS_AL2);

            It should_be_equal = () => isEqual.ShouldBeTrue();
        }

        class when_there_is_no_subdivision
        {
            Because of = () => subdivisionUS_AL1 = new Subdivision();

            It should_have_id = () => subdivisionUS_AL1.Id.ShouldEqual(0);
            It should_have_code = () => subdivisionUS_AL1.Code.ShouldEqual(string.Empty);
            It should_have_name = () => subdivisionUS_AL1.Name.ShouldEqual(string.Empty);
        }

        class when_subdivisions_are_not_equal_v1
        {
            Because of = () => isEqual = subdivisionUS_AL1.Equals(subdivisionUS_AS);

            It should_not_be_equal = () => isEqual.ShouldBeFalse();
        }

        class when_subdivisions_are_equal_v2
        {
            Because of = () => isEqual = subdivisionUS_AL1 == subdivisionUS_AL2;

            It should_be_equal = () => isEqual.ShouldBeTrue();
        }

        class when_subdivisions_are_not_equal_v2
        {
            Because of = () => isEqual = subdivisionUS_AL1 != subdivisionUS_AS;

            It should_not_be_equal = () => isEqual.ShouldBeTrue();
        }

        class when_number_of_subdivisions_in__US__
        {
            static int usSubdivisions;

            Because of = () => usSubdivisions = new Country(840).Subdivisions.Count;

            It should_be_equal = () => usSubdivisions.ShouldEqual(NUMBER_OF_REGIONS_IN_US);
        }
    }
}
