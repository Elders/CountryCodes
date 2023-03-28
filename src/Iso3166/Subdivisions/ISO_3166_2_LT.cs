using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:LT is the entry for Lithuania in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Lithuania, ISO 3166-2 codes are defined for 10 counties, 7 city municipalities, 44 district municipalities and 9 municipalities.
        /// Each code consists of two parts, separated by a hyphen.The first part is LT, the ISO 3166-1 alpha-2 code of Lithuania.The second part is either of the following:
        ///     two letters: counties
        ///     two digits: city municipalities, district municipalities and municipalities
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:LT
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_LT()
        {
            Add(Country.LT, "AL", "Alytus County");
            Add(Country.LT, "KU", "Kaunas County");
            Add(Country.LT, "KL", "Klaipėda County");
            Add(Country.LT, "MR", "Marijampolė County");
            Add(Country.LT, "PN", "Panevėžys County");
            Add(Country.LT, "SA", "Šiauliai County");
            Add(Country.LT, "TA", "Tauragė County");
            Add(Country.LT, "TE", "Telšiai County");
            Add(Country.LT, "UT", "Utena County");
            Add(Country.LT, "VL", "Vilnius County");

            Debug.Assert(_subdivisionsPerCountry[Country.LT].Count == 10, $"{Country.LT} Number of subdivisions is wrong.");
        }
    }
}
