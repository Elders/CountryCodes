using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:BT is the entry for Bhutan in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Bhutan, ISO 3166-2 codes are defined for 20 districts.
        /// Each code consists of two parts, separated by a hyphen.The first part is BT, the ISO 3166-1 alpha-2 code of Bhutan.The second part is two digits,
        /// except Gasa and Trashi Yangtse, which use two letters instead.The first digit indicates the zone where the district is in:
        ///     1: Western
        ///     2: Central (Gasa is also in this zone)
        ///     3: Southern
        ///     4: Eastern(Trashi Yangtse is also in this zone)
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:BT
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_BT()
        {
            Add(Country.BT, "33", "Bumthang");
            Add(Country.BT, "12", "Chhukha");
            Add(Country.BT, "22", "Dagana");
            Add(Country.BT, "GA", "Gasa");
            Add(Country.BT, "13", "Haa");
            Add(Country.BT, "44", "Lhuentse");
            Add(Country.BT, "42", "Monggar");
            Add(Country.BT, "11", "Paro");
            Add(Country.BT, "43", "Pema Gatshel");
            Add(Country.BT, "23", "Punakha");
            Add(Country.BT, "45", "Samdrup Jongkhar");
            Add(Country.BT, "14", "Samtse");
            Add(Country.BT, "31", "Sarpang");
            Add(Country.BT, "15", "Thimphu");
            Add(Country.BT, "41", "Trashigang");
            Add(Country.BT, "TY", "Trashi Yangtse");
            Add(Country.BT, "32", "Trongsa");
            Add(Country.BT, "21", "Tsirang");
            Add(Country.BT, "24", "Wangdue Phodrang");
            Add(Country.BT, "34", "Zhemgang");

            Debug.Assert(_subdivisionsPerCountry[Country.BT].Count == 20, "Number of subdivisions is wrong.");
        }
    }
}
