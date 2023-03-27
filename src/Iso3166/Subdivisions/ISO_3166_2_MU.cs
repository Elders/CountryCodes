using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:MU is the entry for Mauritius in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Mauritius, ISO 3166-2 codes are defined for 3 dependencies and 9 districts.
        /// Each code consists of two parts, separated by a hyphen.The first part is MU, the ISO 3166-1 alpha-2 code of Mauritius.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:MU
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_MU()
        {
            Add(Country.MU, "AG", "Agalega Islands");
            Add(Country.MU, "CC", "Cargados Carajos Shoals");
            Add(Country.MU, "RO", "Rodrigues Island");
            Add(Country.MU, "BL", "Black River");
            Add(Country.MU, "FL", "Flacq");
            Add(Country.MU, "GP", "Grand Port");
            Add(Country.MU, "MO", "Moka");
            Add(Country.MU, "PA", "Pamplemousses");
            Add(Country.MU, "PW", "Plaines Wilhems");
            Add(Country.MU, "PL", "Port Louis");
            Add(Country.MU, "RR", "Rivière du Rempart");
            Add(Country.MU, "SA", "Savanne");

            Debug.Assert(_subdivisionsPerCountry[Country.MU].Count == 12, "Number of subdivisions is wrong.");
        }
    }
}
