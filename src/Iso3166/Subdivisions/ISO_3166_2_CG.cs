using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:CG is the entry for the Republic of the Congo (called simply "Congo" in the standard) in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for the Republic of the Congo, ISO 3166-2 codes are defined for 12 departments.All subdivisions changed their status to departments in 2002.
        /// Each code consists of two parts, separated by a hyphen.The first part is CG, the ISO 3166-1 alpha-2 code of the Republic of the Congo.The second part is either of the following:
        ///     three letters: Brazzaville
        ///     a number: remaining departments
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:CG
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_CG()
        {
            Add(Country.CG, "2", "Lékoumou");
            Add(Country.CG, "5", "Kouilou");
            Add(Country.CG, "7", "Likouala");
            Add(Country.CG, "8", "Cuvette");
            Add(Country.CG, "9", "Niari");
            Add(Country.CG, "11", "Bouenza");
            Add(Country.CG, "12", "Pool");
            Add(Country.CG, "13", "Sangha");
            Add(Country.CG, "14", "Plateaux");
            Add(Country.CG, "15", "Cuvette-Ouest");
            Add(Country.CG, "16", "Pointe-Noire");
            Add(Country.CG, "BZV", "Brazzaville");

            Debug.Assert(_subdivisionsPerCountry[Country.CG].Count == 12, "Number of subdivisions is wrong.");
        }
    }
}
