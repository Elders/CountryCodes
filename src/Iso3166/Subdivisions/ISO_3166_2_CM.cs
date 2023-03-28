using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:CM is the entry for Cameroon in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Cameroon, ISO 3166-2 codes are defined for 10 regions.
        /// Each code consists of two parts, separated by a hyphen.The first part is CM, the ISO 3166-1 alpha-2 code of Cameroon.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:CM
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_CM()
        {
            Add(Country.CM, "AD", "Adamaoua");
            Add(Country.CM, "CE", "Centre");
            Add(Country.CM, "ES", "East");
            Add(Country.CM, "EN", "Far North");
            Add(Country.CM, "LT", "Littoral");
            Add(Country.CM, "NO", "North");
            Add(Country.CM, "NW", "North-West");
            Add(Country.CM, "SU", "South");
            Add(Country.CM, "SW", "South-West");
            Add(Country.CM, "OU", "West");

            Debug.Assert(_subdivisionsPerCountry[Country.CM].Count == 10, $"{Country.CM} Number of subdivisions is wrong.");
        }
    }
}
