using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:VU is the entry for Vanuatu in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Vanuatu, ISO 3166-2 codes are defined for 6 provinces.
        /// Each code consists of two parts, separated by a hyphen. The first part is VU, the ISO 3166-1 alpha-2 code of Vanuatu. The second part is three letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:VU
        /// LastUpdated: 2023-03-20
        /// </remarks>
        internal static void ISO_3166_2_VU()
        {
            Add(Country.VU, "MAP", "Malampa");
            Add(Country.VU, "PAM", "Pénama");
            Add(Country.VU, "SAM", "Sanma");
            Add(Country.VU, "SEE", "Shéfa");
            Add(Country.VU, "TAE", "Taféa");
            Add(Country.VU, "TOB", "Torba");

            Debug.Assert(_subdivisionsPerCountry[Country.VU].Count == 6, "Number of subdivisions is wrong.");
        }
    }
}
