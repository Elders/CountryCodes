using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:LA is the entry for Laos in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Laos, ISO 3166-2 codes are defined for 1 prefecture and 17 provinces.
        /// Each code consists of two parts, separated by a hyphen.The first part is LA, the ISO 3166-1 alpha-2 code of Laos.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:LA
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_LA()
        {
            Add(Country.LA, "VT", "Viangchan");
            Add(Country.LA, "AT", "Attapu");
            Add(Country.LA, "BK", "Bokèo");
            Add(Country.LA, "BL", "Bolikhamxai");
            Add(Country.LA, "CH", "Champasak");
            Add(Country.LA, "HO", "Houaphan");
            Add(Country.LA, "KH", "Khammouan");
            Add(Country.LA, "LM", "Louang Namtha");
            Add(Country.LA, "LP", "Louangphabang");
            Add(Country.LA, "OU", "Oudômxai");
            Add(Country.LA, "PH", "Phôngsali");
            Add(Country.LA, "SL", "Salavan");
            Add(Country.LA, "SV", "Savannakhét");
            Add(Country.LA, "VI", "Viangchan");
            Add(Country.LA, "XA", "Xaignabouli");
            Add(Country.LA, "XE", "Xékong");
            Add(Country.LA, "XI", "Xiangkhouang");
            Add(Country.LA, "XS", "Xaisômboun");

            Debug.Assert(_subdivisionsPerCountry[Country.LA].Count == 18, $"{Country.LA} Number of subdivisions is wrong.");
        }
    }
}
