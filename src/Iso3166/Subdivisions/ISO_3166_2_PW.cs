using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:PW is the entry for Palau in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Palau, ISO 3166-2 codes are defined for 16 states.
        /// Each code consists of two parts, separated by a hyphen.The first part is PW,
        /// the ISO 3166-1 alpha-2 code of Palau.The second part is three digits, which is the old FIPS 6-4 code of the state.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:PW
        /// LastUpdated: 2023-03-21
        /// </remarks>
        internal static void ISO_3166_2_PW()
        {
            Add(Country.PW, "002", "Aimeliik");
            Add(Country.PW, "004", "Airai");
            Add(Country.PW, "010", "Angaur");
            Add(Country.PW, "050", "Hatohobei");
            Add(Country.PW, "100", "Kayangel");
            Add(Country.PW, "150", "Koror");
            Add(Country.PW, "212", "Melekeok");
            Add(Country.PW, "214", "Ngaraard");
            Add(Country.PW, "218", "Ngarchelong");
            Add(Country.PW, "222", "Ngardmau");
            Add(Country.PW, "224", "Ngatpang");
            Add(Country.PW, "226", "Ngchesar");
            Add(Country.PW, "227", "Ngeremlengui");
            Add(Country.PW, "228", "Ngiwal");
            Add(Country.PW, "350", "Peleliu");
            Add(Country.PW, "370", "Sonsorol");

            Debug.Assert(_subdivisionsPerCountry[Country.PW].Count == 16, "Number of subdivisions is wrong.");
        }
    }
}
