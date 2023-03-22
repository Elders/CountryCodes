using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:ZW is the entry for Zimbabwe in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Zimbabwe, ISO 3166-2 codes are defined for 10 provinces.
        /// Each code consists of two parts, separated by a hyphen.The first part is ZW, the ISO 3166-1 alpha-2 code of Zimbabwe.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:ZW
        /// LastUpdated: 2023-03-20
        /// </remarks>
        internal static void ISO_3166_2_ZW()
        {
            Add(Country.ZW, "BU", "Bulawayo");
            Add(Country.ZW, "HA", "Harare");
            Add(Country.ZW, "MA", "Manicaland");
            Add(Country.ZW, "MC", "Mashonaland Central");
            Add(Country.ZW, "ME", "Mashonaland East");
            Add(Country.ZW, "MW", "Mashonaland West");
            Add(Country.ZW, "MV", "Masvingo");
            Add(Country.ZW, "MN", "Matabeleland North");
            Add(Country.ZW, "MS", "Matabeleland South");
            Add(Country.ZW, "MI", "Midlands");

            Debug.Assert(_subdivisionsPerCountry[Country.ZW].Count == 10, "Number of subdivisions is wrong.");
        }
    }
}
