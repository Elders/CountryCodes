using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:YE is the entry for Yemen in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Yemen, ISO 3166-2 codes are defined for 1 municipality and 21 governorates. The municipality Sana'a is the capital of the country and has special status equal to the governorates.
        /// Each code consists of two parts, separated by a hyphen. The first part is YE, the ISO 3166-1 alpha-2 code of Yemen. The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:YE
        /// LastUpdated: 2023-03-20
        /// </remarks>
        internal static void ISO_3166_2_YE()
        {
            Add(Country.YE, "AD", "‘Adan");
            Add(Country.YE, "AM", "‘Amrān");
            Add(Country.YE, "AB", "Abyan");
            Add(Country.YE, "DA", "Aḑ Ḑāli‘");
            Add(Country.YE, "BA", "Al Bayḑā’");
            Add(Country.YE, "HU", "Al Ḩudaydah");
            Add(Country.YE, "JA", "Al Jawf");
            Add(Country.YE, "MR", "Al Mahrah");
            Add(Country.YE, "MW", "Al Maḩwīt");
            Add(Country.YE, "SA", "Amānat al ‘Āşimah");
            Add(Country.YE, "SU", "Arkhabīl Suquţrá");
            Add(Country.YE, "DH", "Dhamār");
            Add(Country.YE, "HD", "Ḩaḑramawt");
            Add(Country.YE, "HJ", "Ḩajjah");
            Add(Country.YE, "IB", "Ibb");
            Add(Country.YE, "LA", "Laḩij");
            Add(Country.YE, "MA", "Ma’rib");
            Add(Country.YE, "RA", "Raymah");
            Add(Country.YE, "SD", "Şāʻdah");
            Add(Country.YE, "SN", "Şanʻā’");
            Add(Country.YE, "SH", "Shabwah");
            Add(Country.YE, "TA", "Tāʻizz");

            Debug.Assert(_subdivisionsPerCountry[Country.YE].Count == 22, $"{Country.YE} Number of subdivisions is wrong.");
        }
    }
}
