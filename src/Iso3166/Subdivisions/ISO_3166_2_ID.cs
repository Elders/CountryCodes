using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:ID is the entry for Indonesia in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Indonesia, ISO 3166-2 codes are defined for two levels of subdivisions:
        ///     7 geographical units(which are major islands or island groups)
        ///     35 provinces, 1 capital district, and 1 special region
        /// Each code consists of two parts, separated by a hyphen.The first part is ID, the ISO 3166-1 alpha-2 code of Indonesia.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:ID
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_ID()
        {
            Add(Country.ID, "AC", "Aceh");
            Add(Country.ID, "BA", "Bali");
            Add(Country.ID, "BT", "Banten");
            Add(Country.ID, "BE", "Bengkulu");
            Add(Country.ID, "GO", "Gorontalo");
            Add(Country.ID, "JK", "Jakarta");
            Add(Country.ID, "JA", "Jambi");
            Add(Country.ID, "JB", "West Java");
            Add(Country.ID, "JT", "Central Java");
            Add(Country.ID, "JI", "East Java");
            Add(Country.ID, "KB", "West Kalimantan");
            Add(Country.ID, "KS", "South Kalimantan");
            Add(Country.ID, "KT", "Central Kalimantan");
            Add(Country.ID, "KI", "East Kalimantan");
            Add(Country.ID, "KU", "North Kalimantan");
            Add(Country.ID, "BB", "Bangka Belitung Islands");
            Add(Country.ID, "KR", "Riau Islands");
            Add(Country.ID, "LA", "Lampung");
            Add(Country.ID, "MA", "Maluku");
            Add(Country.ID, "MU", "North Maluku");
            Add(Country.ID, "NB", "West Nusa Tenggara");
            Add(Country.ID, "NT", "East Nusa Tenggara");
            Add(Country.ID, "PA", "Papua");
            Add(Country.ID, "PB", "West Papua");
            Add(Country.ID, "PE", "Highland Papua");
            Add(Country.ID, "PS", "South Papua");
            Add(Country.ID, "PT", "Central Papua");
            Add(Country.ID, "RI", "Riau");
            Add(Country.ID, "SR", "West Sulawesi");
            Add(Country.ID, "SN", "South Sulawesi");
            Add(Country.ID, "ST", "Central Sulawesi");
            Add(Country.ID, "SG", "Southeast Sulawesi");
            Add(Country.ID, "SA", "North Sulawesi");
            Add(Country.ID, "SB", "West Sumatra");
            Add(Country.ID, "SS", "South Sumatra");
            Add(Country.ID, "SU", "North Sumatra");
            Add(Country.ID, "YO", "Yogyakarta");

            Debug.Assert(_subdivisionsPerCountry[Country.ID].Count == 37, $"{Country.ID} Number of subdivisions is wrong.");
        }
    }
}
