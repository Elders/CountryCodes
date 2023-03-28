using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:PG is the entry for Papua New Guinea in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Papua New Guinea, ISO 3166-2 codes are defined for 1 district,
        /// 20 provinces and 1 autonomous region.The capital of the country Port Moresby forms the National Capital District and has special status equal to the provinces.
        /// Each code consists of two parts, separated by a hyphen. The first part is PG, the ISO 3166-1 alpha-2 code of Papua New Guinea.The second part is three letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:PG
        /// LastUpdated: 2023-03-21
        /// </remarks>
        internal static void ISO_3166_2_PG()
        {
            Add(Country.PG, "NSB", "Bougainville");
            Add(Country.PG, "CPM", "Central");
            Add(Country.PG, "CPK", "Chimbu");
            Add(Country.PG, "EBR", "East New Britain");
            Add(Country.PG, "ESW", "East Sepik");
            Add(Country.PG, "EHG", "Eastern Highlands");
            Add(Country.PG, "EPW", "Enga");
            Add(Country.PG, "GPK", "Gulf");
            Add(Country.PG, "HLA", "Hela");
            Add(Country.PG, "JWK", "Jiwaka");
            Add(Country.PG, "MPM", "Madang");
            Add(Country.PG, "MRL", "Manus");
            Add(Country.PG, "MBA", "Milne Bay");
            Add(Country.PG, "MPL", "Morobe");
            Add(Country.PG, "NCD", "National Capital District");
            Add(Country.PG, "NIK", "New Ireland");
            Add(Country.PG, "NPP", "Northern");
            Add(Country.PG, "SHM", "Southern Highlands");
            Add(Country.PG, "WBK", "West New Britain");
            Add(Country.PG, "SAN", "West Sepik");
            Add(Country.PG, "WPD", "Western");
            Add(Country.PG, "WHM", "Western Highlands");

            Debug.Assert(_subdivisionsPerCountry[Country.PG].Count == 22, $"{Country.PG} Number of subdivisions is wrong.");
        }
    }
}
