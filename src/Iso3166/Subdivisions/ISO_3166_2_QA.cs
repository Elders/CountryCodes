using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:QA is the entry for Qatar in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Qatar, ISO 3166-2 codes are defined for 8 municipalities.
        /// Each code consists of two parts, separated by a hyphen.The first part is QA, the ISO 3166-1 alpha-2 code of Qatar.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:QA
        /// LastUpdated: 2023-03-21
        /// </remarks>
        internal static void ISO_3166_2_QA()
        {
            Add(Country.QA, "DA", "Ad Dawḩah");
            Add(Country.QA, "KH", "Al Khawr wa adh Dhakhīrah");
            Add(Country.QA, "WA", "Al Wakrah");
            Add(Country.QA, "RA", "Ar Rayyān");
            Add(Country.QA, "MS", "Ash Shamāl");
            Add(Country.QA, "SH", "Ash Shīḩānīyah");
            Add(Country.QA, "ZA", "Az̧ Z̧a‘āyin");
            Add(Country.QA, "US", "Umm Şalāl");

            Debug.Assert(_subdivisionsPerCountry[Country.QA].Count == 8, $"{Country.QA} Number of subdivisions is wrong.");
        }
    }
}
