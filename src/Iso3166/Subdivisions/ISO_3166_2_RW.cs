using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:RW is the entry for Rwanda in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Rwanda, ISO 3166-2 codes are defined for 1 city and 4 provinces.The city Kigali is the capital of the country and has special status equal to the provinces.
        /// Each code consists of two parts, separated by a hyphen.The first part is RW, the ISO 3166-1 alpha-2 code of Rwanda.The second part is two digits:
        ///     01: city
        ///     02–05: provinces
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:RW
        /// LastUpdated: 2023-03-21
        /// </remarks>
        internal static void ISO_3166_2_RW()
        {
            Add(Country.RW, "01", "City of Kigali");
            Add(Country.RW, "02", "Eastern");
            Add(Country.RW, "03", "Northern");
            Add(Country.RW, "04", "Western");
            Add(Country.RW, "05", "Southern");
            Add(Country.RW, "C", "Butare");
            Add(Country.RW, "v", "Byumba");
            Add(Country.RW, "E", "Cyangugu");
            Add(Country.RW, "D", "Gikongoro");
            Add(Country.RW, "G", "Gisenyi");
            Add(Country.RW, "B", "Gitarama");
            Add(Country.RW, "J", "Kibungo");
            Add(Country.RW, "F", "Kibuye");
            Add(Country.RW, "K", "Kigali-Rural");
            Add(Country.RW, "L", "Kigali-Ville");
            Add(Country.RW, "M", "Mutara");
            Add(Country.RW, "H", "Ruhengeri");

            Debug.Assert(_subdivisionsPerCountry[Country.RW].Count == 17, $"{Country.RW} Number of subdivisions is wrong.");
        }
    }
}
