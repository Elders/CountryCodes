using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:SO is the entry for Somalia in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Somalia, ISO 3166-2 codes are defined for 18 regions.
        /// Each code consists of two parts, separated by a hyphen.The first part is SO, the ISO 3166-1 alpha-2 code of Somalia.The second part is two letters.
        /// The autonomous region of Somaliland (a sovereign State which claims independence but is not recognized by any nation) the region spans 6 major regions and doesn't have any separate code.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:SO
        /// LastUpdated: 2023-03-21
        /// </remarks>
        internal static void ISO_3166_2_SO()
        {
            Add(Country.SO, "AW", "Awdal");
            Add(Country.SO, "BK", "Bakool");
            Add(Country.SO, "BN", "Banaadir");
            Add(Country.SO, "BR", "Bari");
            Add(Country.SO, "BY", "Bay");
            Add(Country.SO, "GA", "Galguduud");
            Add(Country.SO, "GE", "Gedo");
            Add(Country.SO, "HI", "Hiiraan");
            Add(Country.SO, "JD", "Jubbada Dhexe");
            Add(Country.SO, "JH", "Jubbada Hoose");
            Add(Country.SO, "MU", "Mudug");
            Add(Country.SO, "NU", "Nugaal");
            Add(Country.SO, "SA", "Sanaag");
            Add(Country.SO, "SD", "Shabeellaha Dhexe");
            Add(Country.SO, "SH", "Shabeellaha Hoose");
            Add(Country.SO, "SO", "Sool");
            Add(Country.SO, "TO", "Togdheer");
            Add(Country.SO, "WO", "Woqooyi Galbeed");

            Debug.Assert(_subdivisionsPerCountry[Country.SO].Count == 18, $"{Country.SO} Number of subdivisions is wrong.");
        }
    }
}
