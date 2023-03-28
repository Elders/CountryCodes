using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:NP is the entry for Nepal in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Nepal, ISO 3166-2 codes are defined for 7 provinces.
        /// Each code consists of two parts, separated by a hyphen.The first part is NP, the ISO 3166-1 alpha-2 code of Nepal.The second part is "P" followed by one digit(1–7).
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:NP
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_NP()
        {
            Add(Country.NP, "P1", "Province 1");
            Add(Country.NP, "P2", "Madhesh");
            Add(Country.NP, "P3", "Bagmati");
            Add(Country.NP, "P4", "Gandaki");
            Add(Country.NP, "P5", "Lumbini");
            Add(Country.NP, "P6", "Karnali");
            Add(Country.NP, "P7", "Sudurpashchim");

            Debug.Assert(_subdivisionsPerCountry[Country.NP].Count == 7, $"{Country.NP} Number of subdivisions is wrong.");
        }
    }
}
