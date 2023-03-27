using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:FI is the entry for Finland in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g. provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Finland, ISO 3166-2 codes are defined for 19 regions(under six Regional State Administrative Agencies plus Åland).
        /// Each code consists of two parts, separated by a hyphen.The first part is FI, the ISO 3166-1 alpha-2 code of Finland.The second part is two digits.
        /// Åland(Finnish: Ahvenanmaan maakunta; Swedish: Landskapet Åland), an autonomous region of Finland(also a former province),
        /// is also officially assigned its own country code in ISO 3166-1, with alpha-2 code AX.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:FI
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_FI()
        {
            Add(Country.FI, "01", "Åland");
            Add(Country.FI, "02", "South Karelia");
            Add(Country.FI, "03", "Southern Ostrobothnia");
            Add(Country.FI, "04", "Southern Savonia");
            Add(Country.FI, "05", "Kainuu");
            Add(Country.FI, "06", "Tavastia Proper");
            Add(Country.FI, "07", "Central Ostrobothnia");
            Add(Country.FI, "08", "Central Finland");
            Add(Country.FI, "09", "Kymenlaakso");
            Add(Country.FI, "10", "Lapland");
            Add(Country.FI, "11", "Pirkanmaa");
            Add(Country.FI, "12", "Ostrobothnia");
            Add(Country.FI, "13", "North Karelia");
            Add(Country.FI, "14", "Northern Ostrobothnia");
            Add(Country.FI, "15", "Northern Savonia");
            Add(Country.FI, "16", "Päijänne Tavastia");
            Add(Country.FI, "17", "Satakunta");
            Add(Country.FI, "18", "Uusimaa");
            Add(Country.FI, "19", "Southwest Finland");

            Debug.Assert(_subdivisionsPerCountry[Country.FI].Count == 19, "Number of subdivisions is wrong.");
        }
    }
}
