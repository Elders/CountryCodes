using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:WS is the entry for Samoa in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// The abbreviation is derived from Western Samoa, the country's former name until 1997.
        /// Currently for Samoa, ISO 3166-2 codes are defined for 11 districts.
        /// Each code consists of two parts, separated by a hyphen.The first part is WS, the ISO 3166-1 alpha-2 code of Samoa.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:WS
        /// LastUpdated: 2023-03-21
        /// </remarks>
        internal static void ISO_3166_2_WS()
        {
            Add(Country.WS, "AA", "A'ana");
            Add(Country.WS, "AL", "Aiga-i-le-Tai");
            Add(Country.WS, "AT", "Atua");
            Add(Country.WS, "FA", "Fa'asaleleaga");
            Add(Country.WS, "GE", "Gaga'emauga");
            Add(Country.WS, "GI", "Gagaifomauga");
            Add(Country.WS, "PA", "Palauli");
            Add(Country.WS, "SA", "Satupa'itea");
            Add(Country.WS, "TU", "Tuamasaga");
            Add(Country.WS, "VF", "Va'a-o-Fonoti");
            Add(Country.WS, "VS", "Vaisigano");

            Debug.Assert(_subdivisionsPerCountry[Country.WS].Count == 11, $"{Country.WS} Number of subdivisions is wrong.");
        }
    }
}
