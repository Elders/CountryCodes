using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:GQ is the entry for Equatorial Guinea in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Equatorial Guinea, ISO 3166-2 codes are defined for two levels of subdivisions:
        ///         2 regions(i.e., the Continental Region and the Insular Region)
        ///         8 provinces
        /// Each code consists of two parts, separated by a hyphen.The first part is GQ,
        /// the ISO 3166-1 alpha-2 code of Equatorial Guinea. The second part is either of the following:
        ///         one letter: regions
        ///         two letters: provinces
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:GQ
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_GQ()
        {
            Add(Country.GQ, "C", "Región Continental");
            Add(Country.GQ, "I", "Región Insular");
            Add(Country.GQ, "AN", "Annobón");
            Add(Country.GQ, "BN", "Bioko Norte");
            Add(Country.GQ, "BS", "Bioko Sur");
            Add(Country.GQ, "CS", "Centro Sur");
            Add(Country.GQ, "DJ", "Djibloho");
            Add(Country.GQ, "KN", "Kié-Ntem");
            Add(Country.GQ, "LI", "Litoral");
            Add(Country.GQ, "WN", "Wele-Nzas");

            Debug.Assert(_subdivisionsPerCountry[Country.GQ].Count == 10, "Number of subdivisions is wrong.");
        }
    }
}
