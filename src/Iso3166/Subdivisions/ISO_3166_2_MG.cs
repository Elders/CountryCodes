using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:MG is the entry for Madagascar in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Madagascar, ISO 3166-2 codes are defined for 6 provinces.The provinces were scheduled to be abolished in 2009, and the country would be divided into 22 regions.
        /// Each code consists of two parts, separated by a hyphen.The first part is MG, the ISO 3166-1 alpha-2 code of Madagascar.The second part is a letter.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:MG
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_MG()
        {
            Add(Country.MG, "T", "Antananarivo");
            Add(Country.MG, "D", "Antsiranana");
            Add(Country.MG, "F", "Fianarantsoa");
            Add(Country.MG, "M", "Mahajanga");
            Add(Country.MG, "A", "Toamasina");
            Add(Country.MG, "U", "Toliara");

            Debug.Assert(_subdivisionsPerCountry[Country.MG].Count == 6, "Number of subdivisions is wrong.");
        }
    }
}
