using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:CR is the entry for Costa Rica in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Costa Rica, ISO 3166-2 codes are defined for 7 provinces.
        /// Each code consists of two parts, separated by a hyphen.The first part is CR, the ISO 3166-1 alpha-2 code of Costa Rica.The second part is one or two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:CR
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_CR()
        {
            Add(Country.CR, "A", "Alajuela");
            Add(Country.CR, "C", "Cartago");
            Add(Country.CR, "G", "Guanacaste");
            Add(Country.CR, "H", "Heredia");
            Add(Country.CR, "L", "Limón");
            Add(Country.CR, "P", "Puntarenas");
            Add(Country.CR, "SJ", "San José");

            Debug.Assert(_subdivisionsPerCountry[Country.CR].Count == 7, "Number of subdivisions is wrong.");
        }
    }
}
