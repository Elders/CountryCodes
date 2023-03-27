using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:IE is the entry for Ireland in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Ireland, ISO 3166-2 codes are defined for two levels of subdivisions:
        ///     4 provinces
        ///     26 counties
        /// The 26 counties are traditional counties, which are different from the first-level administrative subdivisions of Ireland.
        /// Each code consists of two parts, separated by a hyphen.The first part is IE, the ISO 3166-1 alpha-2 code of Ireland.The second part is one or two letters.For the counties,
        /// the letters are generally the same as those currently used in vehicle registration plates, with the following exceptions:
        ///     County Cork vehicles rather than CO use C; in ISO 3166-2 the latter is used for the province of Connacht.
        ///     three counties where there were multiple councils and vehicle codes until the Local Government Reform Act 2014:
        ///         County Limerick vehicles rather than LK now use L, which had been restricted to the city of Limerick before 2014
        ///         County Waterford vehicles rather than WD now use W, which had been restricted to the city of Waterford before 2014
        ///         County Tipperary vehicles rather than TA use T . Before 2014 North Tipperary and South Tipperary used TN and TS respectively.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:IE
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_IE()
        {
            Add(Country.IE, "C", "Connaught");
            Add(Country.IE, "L", "Leinster");
            Add(Country.IE, "M", "Munster");
            Add(Country.IE, "U", "Ulster");
            Add(Country.IE, "D", "Dublin");
            Add(Country.IE, "G", "Galway");
            Add(Country.IE, "CW", "Carlow");
            Add(Country.IE, "CN", "Cavan");
            Add(Country.IE, "CE", "Clare");
            Add(Country.IE, "CO", "Cork");
            Add(Country.IE, "DL", "Donegal");
            Add(Country.IE, "KY", "Kerry");
            Add(Country.IE, "KE", "Kildare");
            Add(Country.IE, "KK", "Kilkenny");
            Add(Country.IE, "LS", "Laois");
            Add(Country.IE, "LM", "Leitrim");
            Add(Country.IE, "LK", "Limerick");
            Add(Country.IE, "LD", "Longford");
            Add(Country.IE, "LH", "Louth");
            Add(Country.IE, "MO", "Mayo");
            Add(Country.IE, "MH", "Meath");
            Add(Country.IE, "MN", "Monaghan");
            Add(Country.IE, "OY", "Offaly");
            Add(Country.IE, "RN", "Roscommon");
            Add(Country.IE, "SO", "Sligo");
            Add(Country.IE, "TA", "Tipperary");
            Add(Country.IE, "WD", "Waterford");
            Add(Country.IE, "WH", "Westmeath");
            Add(Country.IE, "WX", "Wexford");
            Add(Country.IE, "WW", "Wicklow");

            Debug.Assert(_subdivisionsPerCountry[Country.IE].Count == 30, "Number of subdivisions is wrong.");
        }
    }
}
