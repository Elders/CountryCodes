using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:GE is the entry for Georgia in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Georgia, ISO 3166-2 codes are defined for 2 autonomous republics, 1 city, and 9 regions.
        /// The city Tbilisi is the capital of the country and has special status equal to the regions.
        /// Each code consists of two parts, separated by a hyphen.The first part is GE, the ISO 3166-1 alpha-2 code of Georgia.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:GE
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_GE()
        {
            Add(Country.GE, "AB", "Abkhazia");
            Add(Country.GE, "AJ", "Ajaria");
            Add(Country.GE, "TB", "Tbilisi");
            Add(Country.GE, "GU", "Guria");
            Add(Country.GE, "IM", "Imereti");
            Add(Country.GE, "KA", "K'akheti");
            Add(Country.GE, "KK", "Kvemo Kartli");
            Add(Country.GE, "MM", "Mtskheta-Mtianeti");
            Add(Country.GE, "RL", "Rach'a-Lechkhumi-Kvemo Svaneti");
            Add(Country.GE, "SZ", "Samegrelo-Zemo Svaneti");
            Add(Country.GE, "SJ", "Samtskhe-Javakheti");
            Add(Country.GE, "SK", "Shida Kartli");

            Debug.Assert(_subdivisionsPerCountry[Country.GE].Count == 12, "Number of subdivisions is wrong.");
        }
    }
}
