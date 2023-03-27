using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:NR is the entry for Nauru in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Nauru, ISO 3166-2 codes are defined for 14 districts.
        /// Each code consists of two parts, separated by a hyphen.The first part is NR, the ISO 3166-1 alpha-2 code of Nauru.The second part is two digits(01–14).
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:NR
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_NR()
        {
            Add(Country.NR, "01", "Aiwo");
            Add(Country.NR, "02", "Anabar");
            Add(Country.NR, "03", "Anetan");
            Add(Country.NR, "04", "Anibare");
            Add(Country.NR, "05", "Baitsi");
            Add(Country.NR, "06", "Boe");
            Add(Country.NR, "07", "Buada");
            Add(Country.NR, "08", "Denigomodu");
            Add(Country.NR, "09", "Ewa");
            Add(Country.NR, "10", "Ijuw");
            Add(Country.NR, "11", "Meneng");
            Add(Country.NR, "12", "Nibok");
            Add(Country.NR, "13", "Uaboe");
            Add(Country.NR, "14", "Yaren");

            Debug.Assert(_subdivisionsPerCountry[Country.NR].Count == 14, "Number of subdivisions is wrong.");
        }
    }
}
