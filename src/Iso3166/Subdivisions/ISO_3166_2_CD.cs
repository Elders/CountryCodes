using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:CD is the entry for the Democratic Republic of the Congo in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for the Democratic Republic of the Congo, ISO 3166-2 codes are defined for 1 city and 25 provinces.The city Kinshasa is the capital of the country and has special status equal to the provinces.
        /// Each code consists of two parts, separated by a hyphen.The first part is CD, the ISO 3166-1 alpha-2 code of the Democratic Republic of the Congo.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:CD
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_CD()
        {
            Add(Country.CD, "BU", "Bas-Uele");
            Add(Country.CD, "EQ", "Equator");
            Add(Country.CD, "HK", "Haut-Katanga");
            Add(Country.CD, "HL", "Haut-Lomami");
            Add(Country.CD, "HU", "Haut-Uele");
            Add(Country.CD, "IT", "Ituri");
            Add(Country.CD, "KS", "Kasai");
            Add(Country.CD, "KC", "Kasai Central");
            Add(Country.CD, "KE", "Kasai-Oriental");
            Add(Country.CD, "KN", "Kinshasa");
            Add(Country.CD, "BC", "Kongo Central");
            Add(Country.CD, "KG", "Kwango");
            Add(Country.CD, "KL", "Kwilu");
            Add(Country.CD, "LO", "Lomami");
            Add(Country.CD, "LU", "Lualaba");
            Add(Country.CD, "MN", "Mai-Ndombe");
            Add(Country.CD, "MA", "Maniema");
            Add(Country.CD, "MO", "Mongala");
            Add(Country.CD, "NK", "North Kivu");
            Add(Country.CD, "NU", "North Ubangi");
            Add(Country.CD, "SA", "Sankuru");
            Add(Country.CD, "SK", "South Kivu");
            Add(Country.CD, "SU", "South Ubangi");
            Add(Country.CD, "TA", "Tanganyika");
            Add(Country.CD, "TO", "Tshopo");
            Add(Country.CD, "TU", "Tshuapa");

            Debug.Assert(_subdivisionsPerCountry[Country.CD].Count == 26, $"{Country.CD} Number of subdivisions is wrong.");
        }
    }
}
