using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:LB is the entry for Lebanon in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Lebanon, ISO 3166-2 codes are defined for eight governorates.Aakkâr Governorate (which contains the current Aakkâr District)
        /// and Baalbek-Hermel Governorate(which contains the current Baalbek District and Hermel District), which are listed, are in the process of being implemented after having been approved for creation in 2003.
        /// Each code consists of two parts, separated by a hyphen.The first part is LB, the ISO 3166-1 alpha-2 code of Lebanon.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:LB
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_LB()
        {
            Add(Country.LB, "AK", "Aakkâr");
            Add(Country.LB, "BH", "Baalbek-Hermel");
            Add(Country.LB, "BI", "Béqaa");
            Add(Country.LB, "BA", "Beyrouth");
            Add(Country.LB, "AS", "Liban-Nord");
            Add(Country.LB, "JA", "Liban-Sud");
            Add(Country.LB, "JL", "Mont-Liban");
            Add(Country.LB, "NA", "Nabatîyé");

            Debug.Assert(_subdivisionsPerCountry[Country.LB].Count == 8, $"{Country.LB} Number of subdivisions is wrong.");
        }
    }
}
