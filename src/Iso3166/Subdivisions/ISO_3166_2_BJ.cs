using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:BJ is the entry for Benin in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Benin, ISO 3166-2 codes are defined for 12 departments.
        /// Each code consists of two parts, separated by a hyphen.The first part is BJ, the ISO 3166-1 alpha-2 code of Benin.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:BJ
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_BJ()
        {
            Add(Country.BJ, "AL", "Alibori");
            Add(Country.BJ, "AK", "Atacora");
            Add(Country.BJ, "AQ", "Atlantique");
            Add(Country.BJ, "BO", "Borgou");
            Add(Country.BJ, "CO", "Collines");
            Add(Country.BJ, "KO", "Couffo");
            Add(Country.BJ, "DO", "Donga");
            Add(Country.BJ, "LI", "Littoral");
            Add(Country.BJ, "MO", "Mono");
            Add(Country.BJ, "OU", "Ouémé");
            Add(Country.BJ, "PL", "Plateau");
            Add(Country.BJ, "ZO", "Zou");

            Debug.Assert(_subdivisionsPerCountry[Country.BJ].Count == 12, $"{Country.BJ} Number of subdivisions is wrong.");
        }
    }
}
