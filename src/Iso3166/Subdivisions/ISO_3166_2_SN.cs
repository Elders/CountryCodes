using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:SN is the entry for Senegal in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Senegal, ISO 3166-2 codes are defined for 14 regions.
        /// Each code consists of two parts, separated by a hyphen.The first part is SN, the ISO 3166-1 alpha-2 code of Senegal.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:SN
        /// LastUpdated: 2023-03-21
        /// </remarks>
        internal static void ISO_3166_2_SN()
        {
            Add(Country.SN, "DK", "Dakar");
            Add(Country.SN, "DB", "Diourbel");
            Add(Country.SN, "FK", "Fatick");
            Add(Country.SN, "KA", "Kaffrine");
            Add(Country.SN, "KL", "Kaolack");
            Add(Country.SN, "KE", "Kédougou");
            Add(Country.SN, "KD", "Kolda");
            Add(Country.SN, "LG", "Louga");
            Add(Country.SN, "MT", "Matam");
            Add(Country.SN, "SL", "Saint-Louis");
            Add(Country.SN, "SE", "Sédhiou");
            Add(Country.SN, "TC", "Tambacounda");
            Add(Country.SN, "TH", "Thiès");
            Add(Country.SN, "ZG", "Ziguinchor");

            Debug.Assert(_subdivisionsPerCountry[Country.SN].Count == 14, $"{Country.SN} Number of subdivisions is wrong.");
        }
    }
}
