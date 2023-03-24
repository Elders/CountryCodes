using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:JM is the entry for Jamaica in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Jamaica, ISO 3166-2 codes are defined for 14 parishes.
        /// Each code consists of two parts, separated by a hyphen.The first part is JM, the ISO 3166-1 alpha-2 code of Jamaica.The second part is two digits(01–14).
        /// The codes are assigned in the counter-clockwise direction starting from Kingston Parish.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:JM
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_JM()
        {
            Add(Country.JM, "13", "Clarendon");
            Add(Country.JM, "09", "Hanover");
            Add(Country.JM, "01", "Kingston");
            Add(Country.JM, "12", "Manchester");
            Add(Country.JM, "04", "Portland");
            Add(Country.JM, "02", "Saint Andrew");
            Add(Country.JM, "06", "Saint Ann");
            Add(Country.JM, "14", "Saint Catherine");
            Add(Country.JM, "11", "Saint Elizabeth");
            Add(Country.JM, "08", "Saint James");
            Add(Country.JM, "05", "Saint Mary");
            Add(Country.JM, "03", "Saint Thomas");
            Add(Country.JM, "07", "Trelawny");
            Add(Country.JM, "10", "Westmoreland");

            Debug.Assert(_subdivisionsPerCountry[Country.JM].Count == 14, "Number of subdivisions is wrong.");
        }
    }
}
