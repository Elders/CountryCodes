using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:PS is the entry for the State of Palestine in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for the State of Palestine, it claims the West Bank and the Gaza Strip, but in fact controls only about 40% of the West Bank.ISO 3166-2 codes are defined for 16 governorates.
        /// Each code consists of two parts, separated by a hyphen. The first part is PS, the ISO 3166-1 alpha-2 code of the State of Palestine. The second part is three letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:PS
        /// LastUpdated: 2023-03-21
        /// </remarks>
        internal static void ISO_3166_2_PS()
        {
            Add(Country.PS, "BTH", "Bethlehem");
            Add(Country.PS, "DEB", "Deir El Balah");
            Add(Country.PS, "GZA", "Gaza");
            Add(Country.PS, "HBN", "Hebron");
            Add(Country.PS, "JEN", "Jenin");
            Add(Country.PS, "JRH", "Jericho and Al Aghwar");
            Add(Country.PS, "JEM", "Jerusalem");
            Add(Country.PS, "KYS", "Khan Yunis");
            Add(Country.PS, "NBS", "Nablus");
            Add(Country.PS, "NGZ", "North Gaza");
            Add(Country.PS, "QQA", "Qalqilya");
            Add(Country.PS, "RFH", "Rafah");
            Add(Country.PS, "RBH", "Ramallah");
            Add(Country.PS, "SLT", "Salfit");
            Add(Country.PS, "TBS", "Tubas");
            Add(Country.PS, "TKM", "Tulkarm");

            Debug.Assert(_subdivisionsPerCountry[Country.PS].Count == 16, $"{Country.PS} Number of subdivisions is wrong.");
        }
    }
}
