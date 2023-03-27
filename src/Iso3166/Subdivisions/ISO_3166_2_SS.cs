using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:SS is the entry for South Sudan in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for South Sudan, ISO 3166-2 codes are defined for 10 states.
        /// Each code consists of two parts, separated by a hyphen.The first part is SS, the ISO 3166-1 alpha-2 code of South Sudan.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:SS
        /// LastUpdated: 2023-03-20
        /// </remarks>
        internal static void ISO_3166_2_SS()
        {
            Add(Country.SS, "EC", "Central Equatoria");
            Add(Country.SS, "EE", "Eastern Equatoria");
            Add(Country.SS, "JG", "Jonglei");
            Add(Country.SS, "LK", "Lakes");
            Add(Country.SS, "BN", "Northern Bahr el Ghazal");
            Add(Country.SS, "UY", "Unity");
            Add(Country.SS, "NU", "Upper Nile");
            Add(Country.SS, "WR", "Warrap");
            Add(Country.SS, "BW", "Western Bahr el Ghazal");
            Add(Country.SS, "EW", "Western Equatoria");

            Debug.Assert(_subdivisionsPerCountry[Country.SS].Count == 10, "Number of subdivisions is wrong.");
        }
    }
}
