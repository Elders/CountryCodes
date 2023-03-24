using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:LS is the entry for Lesotho in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Lesotho, ISO 3166-2 codes are defined for 10 districts.
        /// Each code consists of two parts, separated by a hyphen.The first part is LS, the ISO 3166-1 alpha-2 code of Lesotho.The second part is a letter(A–K except I).
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:LS
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_LS()
        {
            Add(Country.LS, "D", "Berea");
            Add(Country.LS, "B", "Botha-Bothe");
            Add(Country.LS, "C", "Leribe");
            Add(Country.LS, "E", "Mafeteng");
            Add(Country.LS, "A", "Maseru");
            Add(Country.LS, "F", "Mohale's Hoek");
            Add(Country.LS, "J", "Mokhotlong");
            Add(Country.LS, "H", "Qacha's Nek");
            Add(Country.LS, "G", "Quthing");
            Add(Country.LS, "K", "Thaba-Tsek");

            Debug.Assert(_subdivisionsPerCountry[Country.LS].Count == 10, "Number of subdivisions is wrong.");
        }
    }
}
