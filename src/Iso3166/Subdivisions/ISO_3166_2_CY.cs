using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:CY is the entry for Cyprus in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Cyprus, ISO 3166-2 codes are defined for 6 districts.
        /// Each code consists of two parts, separated by a hyphen.The first part is CY, the ISO 3166-1 alpha-2 code of Cyprus.The second part is two digits(01–06).
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:CY
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_CY()
        {
            Add(Country.CY, "04", "Famagusta");
            Add(Country.CY, "06", "Kyrenia");
            Add(Country.CY, "03", "Larnaca");
            Add(Country.CY, "01", "Nicosia");
            Add(Country.CY, "02", "Limassol");
            Add(Country.CY, "05", "Paphos");

            Debug.Assert(_subdivisionsPerCountry[Country.CY].Count == 6, $"{Country.CY} Number of subdivisions is wrong.");
        }
    }
}
