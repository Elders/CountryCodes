using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:BI is the entry for Burundi in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Burundi, ISO 3166-2 codes are defined for 18 provinces.
        /// Each code consists of two parts, separated by a hyphen.The first part is BI, the ISO 3166-1 alpha-2 code of Burundi.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:BI
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_BI()
        {
            Add(Country.BI, "BB", "Bubanza");
            Add(Country.BI, "BM", "Bujumbura Mairie");
            Add(Country.BI, "BL", "Bujumbura Rural");
            Add(Country.BI, "BR", "Bururi");
            Add(Country.BI, "CA", "Cankuzo");
            Add(Country.BI, "CI", "Cibitoke");
            Add(Country.BI, "GI", "Gitega");
            Add(Country.BI, "KR", "Karuzi");
            Add(Country.BI, "KY", "Kayanza");
            Add(Country.BI, "KI", "Kirundo");
            Add(Country.BI, "MA", "Makamba");
            Add(Country.BI, "MU", "Muramvya");
            Add(Country.BI, "MY", "Muyinga");
            Add(Country.BI, "MW", "Mwaro");
            Add(Country.BI, "NG", "Ngozi");
            Add(Country.BI, "RM", "Rumonge");
            Add(Country.BI, "RY", "Ruyigi");
            Add(Country.BI, "RT", "Rutana");

            Debug.Assert(_subdivisionsPerCountry[Country.BI].Count == 18, $"{Country.BI} Number of subdivisions is wrong.");
        }
    }
}
