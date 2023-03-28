using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:CI is the entry for Côte d'Ivoire in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Côte d'Ivoire, ISO 3166-2 codes are defined for 12 districts and 2 autonomous districts.
        /// Each code consists of two parts, separated by a hyphen.The first part is CI, the ISO 3166-1 alpha-2 code of Côte d'Ivoire. The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:CI
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_CI()
        {
            Add(Country.CI, "AB", "Abidjan");
            Add(Country.CI, "BS", "Bas-Sassandra");
            Add(Country.CI, "CM", "Comoé");
            Add(Country.CI, "DN", "Denguélé");
            Add(Country.CI, "GD", "Gôh-Djiboua");
            Add(Country.CI, "LC", "Lacs");
            Add(Country.CI, "LG", "Lagunes");
            Add(Country.CI, "MG", "Montagnes");
            Add(Country.CI, "SM", "Sassandra-Marahoué");
            Add(Country.CI, "SV", "Savanes");
            Add(Country.CI, "VB", "Vallée du Bandama");
            Add(Country.CI, "WR", "Woroba");
            Add(Country.CI, "YM", "Yamoussoukro");
            Add(Country.CI, "ZZ", "Zanzan");

            Debug.Assert(_subdivisionsPerCountry[Country.CI].Count == 14, $"{Country.CI} Number of subdivisions is wrong.");
        }
    }
}
