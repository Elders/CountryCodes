using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:GY is the entry for the Co-operative Republic of Guyana in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Guyana, ISO 3166-2 codes are defined for 10 regions.
        /// Each code consists of two parts, separated by a hyphen.The first part is GY, the ISO 3166-1 alpha-2 code of Guyana.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:GY
        /// LastUpdated: 2023-03-23
        /// </remarks>
        internal static void ISO_3166_2_GY()
        {
            Add(Country.GY, "BA", "Barima-Waini");
            Add(Country.GY, "CU", "Cuyuni-Mazaruni");
            Add(Country.GY, "DE", "Demerara-Mahaica");
            Add(Country.GY, "EB", "East Berbice-Corentyne");
            Add(Country.GY, "ES", "Essequibo Islands-West Demerara");
            Add(Country.GY, "MA", "Mahaica-Berbice");
            Add(Country.GY, "PM", "Pomeroon-Supenaam");
            Add(Country.GY, "PT", "Potaro-Siparuni");
            Add(Country.GY, "UD", "Upper Demerara-Berbice");
            Add(Country.GY, "UT", "Upper Takutu-Upper Essequibo");

            Debug.Assert(_subdivisionsPerCountry[Country.GY].Count == 10, $"{Country.GY} Number of subdivisions is wrong.");
        }
    }
}
