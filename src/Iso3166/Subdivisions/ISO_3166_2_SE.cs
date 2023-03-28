using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:SE is the entry for Sweden in ISO 3166-2,
        /// part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Sweden, ISO 3166-2 codes are defined for 21 counties.
        /// Each code consists of two parts, separated by a hyphen.The first part is SE, the ISO 3166-1 alpha-2 code of Sweden.
        /// The second part is one or two letters, which is the alphabetic code(Swedish: länsbokstav) of the county, and was used in vehicle registration plates until 1973.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:SE
        /// LastUpdated: 2023-03-20
        /// </remarks>
        internal static void ISO_3166_2_SE()
        {
            Add(Country.SE, "K", "Blekinge län");
            Add(Country.SE, "W", "Dalarnas län");
            Add(Country.SE, "I", "Gotlands län");
            Add(Country.SE, "X", "Gävleborgs län");
            Add(Country.SE, "N", "Hallands län");
            Add(Country.SE, "Z", "Jämtlands län");
            Add(Country.SE, "F", "Jönköpings län");
            Add(Country.SE, "H", "Kalmar län");
            Add(Country.SE, "G", "Kronobergs län");
            Add(Country.SE, "BD", "Norrbottens län");
            Add(Country.SE, "M", "Skåne län");
            Add(Country.SE, "AB", "Stockholms län");
            Add(Country.SE, "D", "Södermanlands län");
            Add(Country.SE, "C", "Uppsala län");
            Add(Country.SE, "S", "Värmlands län");
            Add(Country.SE, "AC", "Västerbottens län");
            Add(Country.SE, "Y", "Västernorrlands län");
            Add(Country.SE, "U", "Västmanlands län");
            Add(Country.SE, "O", "Västra Götalands län");
            Add(Country.SE, "T", "Örebro län");
            Add(Country.SE, "E", "Östergötlands län ");

            Debug.Assert(_subdivisionsPerCountry[Country.SE].Count == 21, $"{Country.SE} Number of subdivisions is wrong.");
        }
    }
}
