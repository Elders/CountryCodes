using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:FM is the entry for the Federated States of Micronesia in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for the Federated States of Micronesia, ISO 3166-2 codes are defined for 4 states.
        /// Each code consists of two parts, separated by a hyphen.The first part is FM,
        /// the ISO 3166-1 alpha-2 code of the Federated States of Micronesia.The second part is three letters.The code for Chuuk (FM-TRK) is based on its former name, Truk.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:FM
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_FM()
        {
            Add(Country.FM, "TRK", "Chuuk");
            Add(Country.FM, "KSA", "Kosrae");
            Add(Country.FM, "PNI", "Pohnpei");
            Add(Country.FM, "YAP", "Yap");

            Debug.Assert(_subdivisionsPerCountry[Country.FM].Count == 4, "Number of subdivisions is wrong.");
        }
    }
}
