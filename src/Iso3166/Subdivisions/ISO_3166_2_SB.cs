using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:SB is the entry for Solomon Islands in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Solomon Islands, ISO 3166-2 codes are defined for 1 capital territory and 9 provinces.The capital of the country Honiara forms the Capital Territory and has special status equal to the provinces.
        /// Each code consists of two parts, separated by a hyphen. The first part is SB, the ISO 3166-1 alpha-2 code of Solomon Islands. The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:SB
        /// LastUpdated: 2023-03-21
        /// </remarks>
        internal static void ISO_3166_2_SB()
        {
            Add(Country.SB, "CT", "Capital Territory");
            Add(Country.SB, "CE", "Central");
            Add(Country.SB, "CH", "Choiseul");
            Add(Country.SB, "GU", "Guadalcanal");
            Add(Country.SB, "IS", "Isabel");
            Add(Country.SB, "MK", "Makira-Ulawa");
            Add(Country.SB, "ML", "Malaita");
            Add(Country.SB, "RB", "Rennell and Bellona");
            Add(Country.SB, "TE", "Temotu");
            Add(Country.SB, "WE", "Western");

            Debug.Assert(_subdivisionsPerCountry[Country.SB].Count == 10, "Number of subdivisions is wrong.");
        }
    }
}
