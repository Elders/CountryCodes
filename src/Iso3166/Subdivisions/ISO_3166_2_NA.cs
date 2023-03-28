using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:NA is the entry for Namibia in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Namibia, ISO 3166-2 codes are defined for 14 regions.
        /// Each code consists of two parts, separated by a hyphen.The first part is NA, the ISO 3166-1 alpha-2 code of Namibia.The second part is two letters.
        /// The Kavango East and Kavango West regions were created in August 2013 by a split of Kavango Region (which was named Okavango before 1998). At the same time,
        /// Caprivi and Karas were renamed Zambezi and ǁKaras, respectively.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:NA
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_NA()
        {
            Add(Country.NA, "ER", "Erongo");
            Add(Country.NA, "HA", "Hardap");
            Add(Country.NA, "KA", "Karas");
            Add(Country.NA, "KE", "Kavango East");
            Add(Country.NA, "KW", "Kavango West");
            Add(Country.NA, "KH", "Khomas");
            Add(Country.NA, "KU", "Kunene");
            Add(Country.NA, "OW", "Ohangwena");
            Add(Country.NA, "OH", "Omaheke");
            Add(Country.NA, "OS", "Omusati");
            Add(Country.NA, "ON", "Oshana");
            Add(Country.NA, "OT", "Oshikoto");
            Add(Country.NA, "OD", "Otjozondjupa");
            Add(Country.NA, "CA", "Zambezi");

            Debug.Assert(_subdivisionsPerCountry[Country.NA].Count == 14, $"{Country.NA} Number of subdivisions is wrong.");
        }
    }
}
