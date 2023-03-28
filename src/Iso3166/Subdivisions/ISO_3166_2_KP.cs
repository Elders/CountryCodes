using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:KP is the entry for North Korea(officially the Democratic People's Republic of Korea) in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for North Korea, ISO 3166-2 codes are defined for 2 metropolitan cities, 1 capital city, 1 special city, and 9 provinces.All of them except the metropolitan city are province-level subdivisions.
        /// The three special administrative regions, i.e., the Kaesong Industrial Region, the Mount Kumgang Tourist Region, and the Sinuiju Special Administrative Region, are not listed.
        /// Each code consists of two parts, separated by a hyphen. The first part is KP, the ISO 3166-1 alpha-2 code of North Korea. The second part is two digits:
        ///     01: capital city
        ///     02–10: provinces
        ///     13: special city
        ///     14–15: metropolitan cities
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:KP
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_KP()
        {
            Add(Country.KP, "01", "Pyongyang");
            Add(Country.KP, "13", "Rason");
            Add(Country.KP, "15", "Kaesong");
            Add(Country.KP, "14", "Nampo");
            Add(Country.KP, "02", "South Pyongan");
            Add(Country.KP, "03", "North Pyongan");
            Add(Country.KP, "04", "Chagang");
            Add(Country.KP, "05", "South Hwanghae");
            Add(Country.KP, "06", "North Hwanghae");
            Add(Country.KP, "07", "Kangwon");
            Add(Country.KP, "08", "South Hamgyong");
            Add(Country.KP, "09", "North Hamgyong");
            Add(Country.KP, "10", "Ryanggang");

            Debug.Assert(_subdivisionsPerCountry[Country.KP].Count == 13, $"{Country.KP} Number of subdivisions is wrong.");
        }
    }
}
