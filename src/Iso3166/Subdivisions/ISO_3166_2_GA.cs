using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:GA is the entry for Gabon in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Gabon, ISO 3166-2 codes are defined for 9 provinces.
        /// Each code consists of two parts, separated by a hyphen.The first part is GA, the ISO 3166-1 alpha-2 code of Gabon.The second part is a digit(1–9).
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:GA
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_GA()
        {
            Add(Country.GA, "1", "Estuaire");
            Add(Country.GA, "2", "Haut-Ogooué");
            Add(Country.GA, "3", "Moyen-Ogooué");
            Add(Country.GA, "4", "Ngounié");
            Add(Country.GA, "5", "Nyanga");
            Add(Country.GA, "6", "Ogooué-Ivindo");
            Add(Country.GA, "7", "Ogooué-Lolo");
            Add(Country.GA, "8", "Ogooué-Maritime");
            Add(Country.GA, "9", "Woleu-Ntem");

            Debug.Assert(_subdivisionsPerCountry[Country.GA].Count == 9, $"{Country.GA} Number of subdivisions is wrong.");
        }
    }
}
