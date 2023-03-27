using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:BH is the entry for Bahrain in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Bahrain, ISO 3166-2 codes are defined for 4 governorates.Each code consists of two parts, separated by a hyphen.The first part is BH,
        /// the ISO 3166-1 alpha-2 code of Bahrain.The second part is two digits(13–17, with the exception of 16, which was assigned to Al Wusţá before its abolition in 2014).
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:BH
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_BH()
        {
            Add(Country.BH, "01", "Al Ḩadd");
            Add(Country.BH, "03", "Al Manāmah");
            Add(Country.BH, "10", "Al Minţaqah al Gharbīyah");
            Add(Country.BH, "07", "Al Minţaqah al Wusţá");
            Add(Country.BH, "05", "Al Minţaqah ash Shamālīyah");
            Add(Country.BH, "02", "Al Muḩarraq");
            Add(Country.BH, "09", "Ar Rifāٰ");
            Add(Country.BH, "04", "Jidd Ḩafş");
            Add(Country.BH, "12", "Madīnat Ḩamad");
            Add(Country.BH, "08", "Madīnat ٰĪsá");
            Add(Country.BH, "11", "Minţaqat Juzur Ḩawār");
            Add(Country.BH, "06", "Sitrah");
            Add(Country.BH, "13", "Capital Governorate");
            Add(Country.BH, "14", "Southern Governorate");
            Add(Country.BH, "15", "Muharraq Governorate");
            Add(Country.BH, "17", "Northern Governorate");

            Debug.Assert(_subdivisionsPerCountry[Country.BH].Count == 16, "Number of subdivisions is wrong.");
        }
    }
}
