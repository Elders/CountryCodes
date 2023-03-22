using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:BY is the entry for Belarus in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Belarus, ISO 3166-2 codes are defined for 6 oblasts and 1 city.The city Minsk is the capital of the country and has special status equal to the oblasts.
        /// Each code consists of two parts, separated by a hyphen.The first part is BY, the ISO 3166-1 alpha-2 code of Belarus.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:BY
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_BY()
        {
            Add(Country.BY, "BR", "Brest Region");
            Add(Country.BY, "HO", "Gomel Region");
            Add(Country.BY, "HR", "Grodno Region");
            Add(Country.BY, "MA", "Mogilev Region");
            Add(Country.BY, "MI", "Minsk Region");
            Add(Country.BY, "VI", "Vitebsk Region");
            Add(Country.BY, "HM", "City of Minsk");

            Debug.Assert(_subdivisionsPerCountry[Country.BY].Count == 7, "Number of subdivisions is wrong.");
        }
    }
}
