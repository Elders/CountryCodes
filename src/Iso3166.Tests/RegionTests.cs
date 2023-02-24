﻿using System.Linq;
using Machine.Specifications;

namespace Elders.Iso3166.Tests
{
    [Subject(typeof(Subdivision))]
    public class RegionTests
    {
        static Subdivision region1, region2, region3;
        static bool isEqual;
        static bool isTrue;
        const int TOTAL_NUMBER_OF_REGIONS = 938;
        const int NUMBER_OF_REGIONS_IN_US = 57;
        static Subdivision alabama;

        Establish context = () =>
        {
            region1 = new Subdivision("US-AL");
            region2 = new Subdivision("US-AL");
            region3 = new Subdivision("US-AS");
        };

        class when_region_is__Alabama__
        {
            Because of = () => alabama = new Subdivision("US-AL");

            It should_have_name = () => alabama.Name.ShouldEqual("Alabama");
            It should_have_country_code = () => alabama.Code.ShouldEqual("US-AL");
        }

        class when_regions_are_equal_v1
        {
            Because of = () => isEqual = region1.Equals(region2);

            It should_be_equal = () => isEqual.ShouldBeTrue();
        }

        class when_there_is_no_subdivision
        {
            Because of = () => region1 = new Subdivision();

            It should_have_id = () => region1.Id.ShouldEqual(0);
            It should_have_code = () => region1.Code.ShouldEqual(string.Empty);
            It should_have_name = () => region1.Name.ShouldEqual(string.Empty);
        }

        class when_regions_are_not_equal_v1
        {
            Because of = () => isEqual = region1.Equals(region3);

            It should_not_be_equal = () => isEqual.ShouldBeFalse();
        }

        class when_regions_are_equal_v2
        {
            Because of = () => isEqual = region1 == region2;

            It should_be_equal = () => isEqual.ShouldBeTrue();
        }

        class when_regions_are_not_equal_v2
        {
            Because of = () => isEqual = region1 != region3;

            It should_not_be_equal = () => isEqual.ShouldBeTrue();
        }

        class number_of_regions_in__US__
        {
            static int usRegions;
            Because of = () => usRegions = new Country(840).Subdivisions.Count;

            It should_be_equal = () => usRegions.ShouldEqual(NUMBER_OF_REGIONS_IN_US);
        }
    }
}
