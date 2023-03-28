using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:AU is the entry for Australia in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO), which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Australia, ISO 3166-2 codes are defined for 6 states and 2 territories. Lesser territories that are under the administration of the commonwealth government, such as the Jervis Bay Territory, the Ashmore and Cartier Islands, and the Coral Sea Islands, are not listed.
        /// Each code consists of two parts, separated by a hyphen. The first part is AU, the ISO 3166-1 alpha-2 code of Australia.
        /// The second part is two or three letters, which is the conventional abbreviation of the state or territory (defined in Australian Standard AS 4212-1994).
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:AU
        /// LastUpdated: 2023-03-16
        /// </remarks>
        internal static void ISO_3166_2_AU()
        {
            Add(Country.AU, "NSW", "New South Wales");
            Add(Country.AU, "QLD", "Queensland");
            Add(Country.AU, "SA", "South Australia");
            Add(Country.AU, "TAS", "Tasmania");
            Add(Country.AU, "VIC", "Victoria");
            Add(Country.AU, "WA", "Western Australia");
            Add(Country.AU, "ACT", "Australian Capital Territory");
            Add(Country.AU, "NT", "Northern Territory");

            Debug.Assert(_subdivisionsPerCountry[Country.AU].Count == 8, $"{Country.AU} Number of subdivisions is wrong.");
        }
    }
}
