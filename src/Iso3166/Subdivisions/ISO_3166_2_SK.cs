using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:SK is the entry for Slovakia in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Slovakia, ISO 3166-2 codes are defined for 8 regions.
        /// Each code consists of two parts, separated by a hyphen.The first part is SK, the ISO 3166-1 alpha-2 code of Slovakia.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:SK
        /// LastUpdated: 2023-03-21
        /// </remarks>
        internal static void ISO_3166_2_SK()
        {
            Add(Country.SK, "BC", "Banskobystrický kraj");
            Add(Country.SK, "BL", "Bratislavský kraj");
            Add(Country.SK, "KI", "Košický kraj");
            Add(Country.SK, "NI", "Nitriansky kraj");
            Add(Country.SK, "PV", "Prešovský kraj");
            Add(Country.SK, "TC", "Trenčiansky kraj");
            Add(Country.SK, "TA", "Trnavský kraj");
            Add(Country.SK, "ZI", "Žilinský kraj");

            Debug.Assert(_subdivisionsPerCountry[Country.SK].Count == 8, "Number of subdivisions is wrong.");
        }
    }
}
