using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:TM is the entry for Turkmenistan in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Turkmenistan, ISO 3166-2 codes are defined for 5 regions and 1 city.The city Ashgabat is the capital of the country and has special status equal to the regions.
        /// Each code consists of two parts, separated by a hyphen.The first part is TM, the ISO 3166-1 alpha-2 code of Turkmenistan.The second part is a letter.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:TM
        /// LastUpdated: 2023-03-20
        /// </remarks>
        internal static void ISO_3166_2_TM()
        {
            Add(Country.TM, "A", "Ahal");
            Add(Country.TM, "B", "Balkan");
            Add(Country.TM, "D", "Daşoguz");
            Add(Country.TM, "L", "Lebap");
            Add(Country.TM, "M", "Mary");
            Add(Country.TM, "S", "Aşgabat");

            Debug.Assert(_subdivisionsPerCountry[Country.TM].Count == 6, $"{Country.TM} Number of subdivisions is wrong.");
        }
    }
}
