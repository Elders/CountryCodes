using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:PK is the entry for Pakistan in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Pakistan, ISO 3166-2 codes are defined for 1 federal capital territory, 4 provinces, and 2 Pakistan administered areas.
        /// The Islamabad Capital Territory contains the capital of the country Islamabad and has special status equal to the provinces and territory.
        /// Each code consists of two parts, separated by a hyphen.The first part is PK, the ISO 3166-1 alpha-2 code of Pakistan.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:PK
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_PK()
        {
            Add(Country.PK, "IS", "Islamabad");
            Add(Country.PK, "BA", "Balochistan");
            Add(Country.PK, "KP", "Khyber Pakhtunkhwa");
            Add(Country.PK, "PB", "Punjab");
            Add(Country.PK, "SD", "Sindh");
            Add(Country.PK, "JK", "Azad Jammu and Kashmir");
            Add(Country.PK, "GB", "Gilgit-Baltistan");

            Debug.Assert(_subdivisionsPerCountry[Country.PK].Count == 7, "Number of subdivisions is wrong.");
        }
    }
}
