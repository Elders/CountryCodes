using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:MM is the entry for Myanmar in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// As of 2020, Myanmar ISO 3166-2 codes are defined for 7 regions, 7 states, and 1 union territory.
        /// Each code consists of two parts, separated by a hyphen. The first part is MM, the ISO 3166-1 alpha-2 code of Myanmar.The second part is two digits:
        ///     01–07: regions
        ///     11–17: states
        ///     18: union territory
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:MM
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_MM()
        {
            Add(Country.MM, "07", "Ayeyarwady");
            Add(Country.MM, "02", "Bago");
            Add(Country.MM, "03", "Magway");
            Add(Country.MM, "04", "Mandalay");
            Add(Country.MM, "01", "Sagaing");
            Add(Country.MM, "05", "Tanintharyi");
            Add(Country.MM, "06", "Yangon");
            Add(Country.MM, "14", "Chin");
            Add(Country.MM, "11", "Kachin");
            Add(Country.MM, "12", "Kayah");
            Add(Country.MM, "13", "Kayin");
            Add(Country.MM, "15", "Mon");
            Add(Country.MM, "16", "Rakhine");
            Add(Country.MM, "17", "Shan");
            Add(Country.MM, "18", "Nay Pyi Taw");

            Debug.Assert(_subdivisionsPerCountry[Country.MM].Count == 15, "Number of subdivisions is wrong.");
        }
    }
}
