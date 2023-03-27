using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:HU is the entry for Hungary in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Hungary, ISO 3166-2 codes are defined for 1 capital city, 19 counties, and 23 cities with county rights.
        /// The capital of the country Budapest has special status equal to the counties, while the cities with county rights, often called urban counties, have extended powers but are technically not independent of the counties.
        /// Each code consists of two parts, separated by a hyphen. The first part is HU, the ISO 3166-1 alpha-2 code of Hungary.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:HU
        /// LastUpdated: 2023-03-23
        /// </remarks>
        internal static void ISO_3166_2_HU()
        {
            Add(Country.HU, "BU", "Budapest");
            Add(Country.HU, "BK", "Bács-Kiskun");
            Add(Country.HU, "BA", "Baranya");
            Add(Country.HU, "BE", "Békés");
            Add(Country.HU, "BZ", "Borsod-Abaúj-Zemplén");
            Add(Country.HU, "CS", "Csongrád-Csanád");
            Add(Country.HU, "FE", "Fejér");
            Add(Country.HU, "GS", "Győr-Moson-Sopron");
            Add(Country.HU, "HB", "Hajdú-Bihar");
            Add(Country.HU, "HE", "Heves");
            Add(Country.HU, "JN", "Jász-Nagykun-Szolnok");
            Add(Country.HU, "KE", "Komárom-Esztergom");
            Add(Country.HU, "NO", "Nógrád");
            Add(Country.HU, "PE", "Pest");
            Add(Country.HU, "SO", "Somogy");
            Add(Country.HU, "SZ", "Szabolcs-Szatmár-Bereg");
            Add(Country.HU, "TO", "Tolna");
            Add(Country.HU, "VA", "Vas");
            Add(Country.HU, "VE", "Veszprém");
            Add(Country.HU, "ZA", "Zala");
            Add(Country.HU, "BC", "Békéscsaba");
            Add(Country.HU, "DE", "Debrecen");
            Add(Country.HU, "DU", "Dunaújváros");
            Add(Country.HU, "EG", "Eger");
            Add(Country.HU, "ER", "Érd");
            Add(Country.HU, "GY", "Győr");
            Add(Country.HU, "HV", "Hódmezővásárhely");
            Add(Country.HU, "KV", "Kaposvár");
            Add(Country.HU, "KM", "Kecskemét");
            Add(Country.HU, "MI", "Miskolc");
            Add(Country.HU, "NK", "Nagykanizsa");
            Add(Country.HU, "NY", "Nyíregyháza");
            Add(Country.HU, "PS", "Pécs");
            Add(Country.HU, "ST", "Salgótarján");
            Add(Country.HU, "SN", "Sopron");
            Add(Country.HU, "SD", "Szeged");
            Add(Country.HU, "SF", "Székesfehérvár");
            Add(Country.HU, "SS", "Szekszárd");
            Add(Country.HU, "SK", "Szolnok");
            Add(Country.HU, "SH", "Szombathely");
            Add(Country.HU, "TB", "Tatabánya");
            Add(Country.HU, "VM", "Veszprém");
            Add(Country.HU, "ZE", "Zalaegerszeg");

            Debug.Assert(_subdivisionsPerCountry[Country.HU].Count == 43, "Number of subdivisions is wrong.");
        }
    }
}
