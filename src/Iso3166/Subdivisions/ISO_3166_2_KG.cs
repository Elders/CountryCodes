using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:KG is the entry for Kyrgyzstan in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Kyrgyzstan, ISO 3166-2 codes are defined for 2 cities and 7 regions.The cities Bishkek and Osh have special status equal to the regions.
        /// Each code consists of two parts, separated by a hyphen. The first part is KG, the ISO 3166-1 alpha-2 code of Kyrgyzstan.The second part is either of the following:
        ///     one letter: regions
        ///     two letters: city
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:KG
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_KG()
        {
            Add(Country.KG, "GB", "Bishkek Shaary");
            Add(Country.KG, "GO", "Osh Shaary");
            Add(Country.KG, "B", "Batken");
            Add(Country.KG, "C", "Chüy");
            Add(Country.KG, "J", "Jalal-Abad");
            Add(Country.KG, "N", "Naryn");
            Add(Country.KG, "O", "Osh");
            Add(Country.KG, "T", "Talas");
            Add(Country.KG, "Y", "Ysyk-Köl");

            Debug.Assert(_subdivisionsPerCountry[Country.KG].Count == 9, $"{Country.KG} Number of subdivisions is wrong.");
        }
    }
}
