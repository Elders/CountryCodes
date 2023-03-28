using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:HN is the entry for Honduras in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Honduras, ISO 3166-2 codes are defined for 18 departments.
        /// Each code consists of two parts, separated by a hyphen.The first part is HN, the ISO 3166-1 alpha-2 code of Honduras.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:HN
        /// LastUpdated: 2023-03-23
        /// </remarks>
        internal static void ISO_3166_2_HN()
        {
            Add(Country.HN, "AT", "Atlántida");
            Add(Country.HN, "CH", "Choluteca");
            Add(Country.HN, "CL", "Colón");
            Add(Country.HN, "CM", "Comayagua");
            Add(Country.HN, "CP", "Copán");
            Add(Country.HN, "CR", "Cortés");
            Add(Country.HN, "EP", "El Paraíso");
            Add(Country.HN, "FM", "Francisco Morazán");
            Add(Country.HN, "GD", "Gracias a Dios");
            Add(Country.HN, "IN", "Intibucá");
            Add(Country.HN, "IB", "Islas de la Bahía");
            Add(Country.HN, "LP", "La Paz");
            Add(Country.HN, "LE", "Lempira");
            Add(Country.HN, "OC", "Ocotepeque");
            Add(Country.HN, "OL", "Olancho");
            Add(Country.HN, "SB", "Santa Bárbara");
            Add(Country.HN, "VA", "Valle");
            Add(Country.HN, "YO", "Yoro");

            Debug.Assert(_subdivisionsPerCountry[Country.HN].Count == 18, $"{Country.HN} Number of subdivisions is wrong.");
        }
    }
}
