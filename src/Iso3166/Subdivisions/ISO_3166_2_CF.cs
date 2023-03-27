using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166 - 2:CF is the entry for the Central African Republic in ISO 3166 - 2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166 - 1.
        /// Currently for the Central African Republic, ISO 3166 - 2 codes are defined for 1 commune, 14 prefectures, and 2 economic prefectures.
        /// The commune Bangui is the capital of the country and has special status equal to the prefectures and economic prefectures.
        /// Each code consists of two parts, separated by a hyphen.The first part is CF, the ISO 3166 - 1 alpha - 2 code of the Central African Republic.The second part is either of the following:
        ///     two letters: prefectures and economic prefectures
        ///     three letters: commune
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:CF
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_CF()
        {
            Add(Country.CF, "BGF", "Bangui");
            Add(Country.CF, "BB", "Bamingui-Bangoran");
            Add(Country.CF, "BK", "Basse-Kotto");
            Add(Country.CF, "HM", "Haut-Mbomou");
            Add(Country.CF, "HK", "Haute-Kotto");
            Add(Country.CF, "HS", "Haute-Sangha");
            Add(Country.CF, "KG", "Kémo-Gribingui");
            Add(Country.CF, "LB", "Lobaye");
            Add(Country.CF, "MB", "Mbomou");
            Add(Country.CF, "NM", "Nana-Mambéré");
            Add(Country.CF, "MP", "Ombella-Mpoko");
            Add(Country.CF, "UK", "Ouaka");
            Add(Country.CF, "AC", "Ouham");
            Add(Country.CF, "OP", "Ouham-Pendé");
            Add(Country.CF, "VK", "Vakaga");
            Add(Country.CF, "KB", "Gribingui");
            Add(Country.CF, "SE", "Sangha");

            Debug.Assert(_subdivisionsPerCountry[Country.CF].Count == 17, "Number of subdivisions is wrong.");
        }
    }
}
