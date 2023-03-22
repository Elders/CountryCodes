using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:UM is the entry for the United States Minor Outlying Islands in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for the United States Minor Outlying Islands, ISO 3166-2 codes are defined for 9 "islands, groups of islands".
        /// Each code consists of two parts, separated by a hyphen.The first part is UM, the ISO 3166-1 alpha-2 code of the United States Minor Outlying Islands.The second part is two digits,
        /// which is the old FIPS 5-2 numeric code of the island or group of islands.
        /// As an outlying area of the United States, the United States Minor Outlying Islands are also assigned the ISO 3166-2 code US-UM under the entry for the United States.
        /// ISO 3166-2:UM does not include the Caribbean islands of Serranilla Bank or Bajo Nuevo Bank, both of which are claimed by the United States but administered by Colombia.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:UM
        /// LastUpdated: 2023-03-20
        /// </remarks>
        internal static void ISO_3166_2_UM()
        {
            Add(Country.UM, "81", "Baker Island");
            Add(Country.UM, "84", "Howland Island");
            Add(Country.UM, "86", "Jarvis Island");
            Add(Country.UM, "67", "Johnston Atoll");
            Add(Country.UM, "89", "Kingman Reef");
            Add(Country.UM, "71", "Midway Islands");
            Add(Country.UM, "76", "Navassa Island");
            Add(Country.UM, "95", "Palmyra Atoll");
            Add(Country.UM, "79", "Wake Island");

            Debug.Assert(_subdivisionsPerCountry[Country.UM].Count == 9, "Number of subdivisions is wrong.");
        }
    }
}
