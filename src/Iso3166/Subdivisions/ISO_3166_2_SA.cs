using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:SA is the entry for Saudi Arabia in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Saudi Arabia, ISO 3166-2 codes are defined for 13 regions.
        /// Each code consists of two parts, separated by a hyphen.The first part is SA, the ISO 3166-1 alpha-2 code of Saudi Arabia.The second part is two digits (01–14 except 13).
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:SA
        /// LastUpdated: 2023-03-21
        /// </remarks>
        internal static void ISO_3166_2_SA()
        {
            Add(Country.SA, "14", "'Asīr");
            Add(Country.SA, "11", "Al Bāḩah");
            Add(Country.SA, "08", "Al Ḩudūd ash Shamālīyah");
            Add(Country.SA, "12", "Al Jawf");
            Add(Country.SA, "03", "Al Madīnah al Munawwarah");
            Add(Country.SA, "05", "Al Qaşīm");
            Add(Country.SA, "01", "Ar Riyāḑ");
            Add(Country.SA, "04", "Ash Sharqīyah");
            Add(Country.SA, "06", "Ḩā'il");
            Add(Country.SA, "09", "Jāzān");
            Add(Country.SA, "02", "Makkah al Mukarramah");
            Add(Country.SA, "10", "Najrān");
            Add(Country.SA, "07", "Tabūk");

            Debug.Assert(_subdivisionsPerCountry[Country.SA].Count == 13, $"{Country.SA} Number of subdivisions is wrong.");
        }
    }
}
