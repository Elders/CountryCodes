using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:IL is the entry for Israel in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Israel, ISO 3166-2 codes are defined for 6 districts.
        /// Each code consists of two parts, separated by a hyphen.The first part is IL, the ISO 3166-1 alpha-2 code of Israel.The second part is one or two letters.
        /// The code for Yerushalayim (IL-JM) is assigned based on its English name, Jerusalem.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:IL
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_IL()
        {
            Add(Country.IL, "D", "Southern");
            Add(Country.IL, "M", "Central");
            Add(Country.IL, "Z", "Northern");
            Add(Country.IL, "HA", "Haifa");
            Add(Country.IL, "TA", "Tel Aviv");
            Add(Country.IL, "JM", "Jerusalem");

            Debug.Assert(_subdivisionsPerCountry[Country.IL].Count == 6, $"{Country.IL} Number of subdivisions is wrong.");
        }
    }
}
