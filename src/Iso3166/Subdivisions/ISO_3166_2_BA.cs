using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:BA is the entry for Bosnia and Herzegovina in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Bosnia and Herzegovina, ISO 3166-2 codes are defined for 2 entities and 1 district with special status.The Brčko District has special status, formally belonging to both entities but effectively self-governing.
        /// Each code consists of two parts, separated by a hyphen. The first part is BA, the ISO 3166-1 alpha-2 code of Bosnia and Herzegovina.The second part is three letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:BA
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_BA()
        {
            Add(Country.BA, "BIH", "Federation of Bosnia and Herzegovina");
            Add(Country.BA, "SRP", "Republika Srpska");
            Add(Country.BA, "BRC", "Brčko District");

            Debug.Assert(_subdivisionsPerCountry[Country.BA].Count == 3, $"{Country.BA} Number of subdivisions is wrong.");
        }
    }
}
