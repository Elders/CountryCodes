using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:AD is the entry for Andorra in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Andorra, ISO 3166-2 codes are defined for 7 parishes.
        /// Each code consists of two parts, separated by a hyphen.The first part is AD, the ISO 3166-1 alpha-2 code of Andorra.The second part is two digits:
        ///     02–06: parishes created before 1978 except Andorra la Vella
        ///     07–08: Andorra la Vella and Escaldes-Engordany(Escaldes-Engordany split from Andorra la Vella in 1978)
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:AD
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_AD()
        {
            Add(Country.AD, "07", "Andorra la Vella");
            Add(Country.AD, "02", "Canillo");
            Add(Country.AD, "03", "Encamp");
            Add(Country.AD, "08", "Escaldes-Engordany");
            Add(Country.AD, "04", "La Massana");
            Add(Country.AD, "05", "Ordino");
            Add(Country.AD, "06", "Sant Julià de Lòria");

            Debug.Assert(_subdivisionsPerCountry[Country.AD].Count == 7, "Number of subdivisions is wrong.");
        }
    }
}
