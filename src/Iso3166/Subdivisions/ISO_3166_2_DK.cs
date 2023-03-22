using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:DK is the entry for Denmark in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// The current version of the standard defines codes for the five regions of Denmark created during the municipal reform of 2007.[1]
        /// Each code consists of two parts, separated by a hyphen.The first part is DK, the ISO 3166-1 alpha-2 code for Denmark.The second part is a two-digit number between 81 and 85.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:DK
        /// LastUpdated: 2023-03-16
        /// </remarks>
        internal static void ISO_3166_2_DK()
        {
            Add(Country.DK, "84", "Capital Region of Denmark");
            Add(Country.DK, "82", "Central Denmark Region");
            Add(Country.DK, "81", "North Denmark Region");
            Add(Country.DK, "85", "Region Zealand");
            Add(Country.DK, "83", "Region of Southern Denmark");

            Debug.Assert(_subdivisionsPerCountry[Country.DK].Count == 5, "Number of subdivisions is wrong.");
        }
    }
}
