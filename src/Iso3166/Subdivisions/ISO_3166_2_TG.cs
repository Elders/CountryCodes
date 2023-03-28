using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:TG is the entry for Togo in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Togo, ISO 3166-2 codes are defined for 5 regions.
        /// Each code consists of two parts, separated by a hyphen.The first part is TG, the ISO 3166-1 alpha-2 code of Togo.The second part is a letter.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:TG
        /// LastUpdated: 2023-03-20
        /// </remarks>
        internal static void ISO_3166_2_TG()
        {
            Add(Country.TG, "C", "Centrale");
            Add(Country.TG, "K", "Kara");
            Add(Country.TG, "M", "Maritime");
            Add(Country.TG, "P", "Plateaux");
            Add(Country.TG, "S", "Savanes");

            Debug.Assert(_subdivisionsPerCountry[Country.TG].Count == 5, $"{Country.TG} Number of subdivisions is wrong.");
        }
    }
}
