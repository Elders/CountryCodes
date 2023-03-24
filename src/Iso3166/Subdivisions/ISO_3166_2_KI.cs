using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:KI is the entry for Kiribati in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Kiribati, ISO 3166-2 codes are defined for 3 groups of islands(20 inhabited islands).
        /// The groups of islands are geographical subdivisions, as the country has no official administrative subdivisions.
        /// Each code consists of two parts, separated by a hyphen.The first part is KI, the ISO 3166-1 alpha-2 code of Kiribati.The second part is a letter.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:KI
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_KI()
        {
            Add(Country.KI, "G", "Gilbert Islands");
            Add(Country.KI, "L", "Line Islands");
            Add(Country.KI, "P", "Phoenix Islands");

            Debug.Assert(_subdivisionsPerCountry[Country.KI].Count == 3, "Number of subdivisions is wrong.");
        }
    }
}
