using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:TN is the entry for Tunisia in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Tunisia, ISO 3166-2 codes are defined for 24 governorates.
        /// Each code consists of two parts, separated by a hyphen.The first part is TN,
        /// the ISO 3166-1 alpha-2 code of Tunisia.The second part is two digits.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:TN
        /// LastUpdated: 2023-03-20
        /// </remarks>
        internal static void ISO_3166_2_TN()
        {
            Add(Country.TN, "31", "Béja");
            Add(Country.TN, "13", "Ben Arous");
            Add(Country.TN, "23", "Bizerte");
            Add(Country.TN, "81", "Gabès");
            Add(Country.TN, "71", "Gafsa");
            Add(Country.TN, "32", "Jendouba");
            Add(Country.TN, "41", "Kairouan");
            Add(Country.TN, "42", "Kasserine");
            Add(Country.TN, "73", "Kébili");
            Add(Country.TN, "12", "L'Ariana");
            Add(Country.TN, "14", "La Manouba");
            Add(Country.TN, "33", "Le Kef");
            Add(Country.TN, "53", "Mahdia");
            Add(Country.TN, "82", "Médenine");
            Add(Country.TN, "52", "Monastir");
            Add(Country.TN, "21", "Nabeul");
            Add(Country.TN, "61", "Sfax");
            Add(Country.TN, "43", "Sidi Bouzid");
            Add(Country.TN, "34", "Siliana");
            Add(Country.TN, "51", "Sousse");
            Add(Country.TN, "83", "Tataouine");
            Add(Country.TN, "72", "Tozeur");
            Add(Country.TN, "11", "Tunis");
            Add(Country.TN, "22", "Zaghouan");

            Debug.Assert(_subdivisionsPerCountry[Country.TN].Count == 24, $"{Country.TN} Number of subdivisions is wrong.");
        }
    }
}
