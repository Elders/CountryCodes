using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:NE is the entry for Niger in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Niger, ISO 3166-2 codes are defined for 1 urban community and 7 regions.The urban community Niamey is the capital of the country and has special status equal to the regions.
        /// Each code consists of two parts, separated by a hyphen.The first part is NE, the ISO 3166-1 alpha-2 code of Niger.The second part is a digit:
        ///     1–7: regions
        ///     8: urban community
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:NE
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_NE()
        {
            Add(Country.NE, "8", "Niamey");
            Add(Country.NE, "1", "Agadez");
            Add(Country.NE, "2", "Diffa");
            Add(Country.NE, "3", "Dosso");
            Add(Country.NE, "4", "Maradi");
            Add(Country.NE, "5", "Tahoua");
            Add(Country.NE, "6", "Tillabéri");
            Add(Country.NE, "7", "Zinder");

            Debug.Assert(_subdivisionsPerCountry[Country.NE].Count == 8, "Number of subdivisions is wrong.");
        }
    }
}
