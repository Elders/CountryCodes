using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:AO is the entry for Angola in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Angola, ISO 3166-2 codes are defined for 18 provinces.
        /// Each code consists of two parts, separated by a hyphen.
        /// The first part is AO, the ISO 3166-1 alpha-2 code of Angola.The second part is three letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:AO
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_AO()
        {
            Add(Country.AO, "BGO", "Bengo");
            Add(Country.AO, "CUS", "Cuanza-Sul");
            Add(Country.AO, "CNN", "Cunene");
            Add(Country.AO, "HUA", "Huambo");
            Add(Country.AO, "HUI", "Huíla");
            Add(Country.AO, "LUA", "Luanda");
            Add(Country.AO, "LNO", "Lunda-Norte");
            Add(Country.AO, "LSU", "Lunda-Sul");
            Add(Country.AO, "MAL", "Malange");
            Add(Country.AO, "MOX", "Moxico");
            Add(Country.AO, "NAM", "Namibe");
            Add(Country.AO, "UIG", "Uíge");
            Add(Country.AO, "ZAI", "Zaire");

            Debug.Assert(_subdivisionsPerCountry[Country.AO].Count == 13, "Number of subdivisions is wrong.");
        }
    }
}
