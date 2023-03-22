using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:TL is the entry for East Timor in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for East Timor, ISO 3166-2 codes are defined for 12 municipalities and 1 special administrative region.
        /// Each code consists of two parts, separated by a hyphen.The first part is TL, the ISO 3166-1 alpha-2 code of East Timor.The second part is two letters.
        /// Before it became independent from Indonesia in 2002, East Timor was officially assigned the ISO 3166-1 alpha-2 code TP. Moreover,
        /// it was also assigned the ISO 3166-2 code ID-TT under the entry for Indonesia.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:TL
        /// LastUpdated: 2023-03-20
        /// </remarks>
        internal static void ISO_3166_2_TL()
        {
            Add(Country.TL, "AL", "Aileu");
            Add(Country.TL, "AN", "Ainaro");
            Add(Country.TL, "BA", "Baucau");
            Add(Country.TL, "BO", "Bobonaro");
            Add(Country.TL, "CO", "Cova Lima");
            Add(Country.TL, "DI", "Díli");
            Add(Country.TL, "ER", "Ermera");
            Add(Country.TL, "LA", "Lautém");
            Add(Country.TL, "LI", "Liquiça");
            Add(Country.TL, "MT", "Manatuto");
            Add(Country.TL, "MF", "Manufah");
            Add(Country.TL, "OE", "Oé-Cusse Ambeno");
            Add(Country.TL, "VI", "Viqueque");

            Debug.Assert(_subdivisionsPerCountry[Country.TL].Count == 13, "Number of subdivisions is wrong.");
        }
    }
}
