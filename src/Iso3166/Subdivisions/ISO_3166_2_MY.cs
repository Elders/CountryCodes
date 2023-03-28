using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:MY is the entry for Malaysia in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Malaysia, ISO 3166-2 codes are defined for three federal territories and 13 states.
        /// Each code consists of two parts, separated by a hyphen.The first part is MY, the ISO 3166-1 alpha-2 code of Malaysia.The second part is two digits:
        ///         01–13: states
        ///         14–16: federal territories
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:MY
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_MY()
        {
            Add(Country.MY, "14", "Wilayah Persekutuan Kuala Lumpur");
            Add(Country.MY, "15", "Wilayah Persekutuan Labuan");
            Add(Country.MY, "16", "Wilayah Persekutuan Putrajaya");
            Add(Country.MY, "01", "Johor");
            Add(Country.MY, "02", "Kedah");
            Add(Country.MY, "03", "Kelantan");
            Add(Country.MY, "04", "Melaka");
            Add(Country.MY, "05", "Negeri Sembilan");
            Add(Country.MY, "06", "Pahang");
            Add(Country.MY, "08", "Perak");
            Add(Country.MY, "09", "Perlis");
            Add(Country.MY, "07", "Pulau Pinang");
            Add(Country.MY, "12", "Sabah");
            Add(Country.MY, "13", "Sarawak");
            Add(Country.MY, "10", "Selangor");
            Add(Country.MY, "11", "Terengganu");

            Debug.Assert(_subdivisionsPerCountry[Country.MY].Count == 16, $"{Country.MY} Number of subdivisions is wrong.");
        }
    }
}
