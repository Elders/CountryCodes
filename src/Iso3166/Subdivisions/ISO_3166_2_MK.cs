using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:MK is the entry for North Macedonia in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for North Macedonia, ISO 3166-2 codes are defined for 80 municipalities.
        /// Each code consists of two parts, separated by a hyphen.The first part is MK, the ISO 3166-1 alpha-2 code of North Macedonia.The second part is 3 digits.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:MK
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_MK()
        {
            Add(Country.MK, "801", "Aerodrom");
            Add(Country.MK, "802", "Aračinovo");
            Add(Country.MK, "201", "Berovo");
            Add(Country.MK, "501", "Bitola");
            Add(Country.MK, "401", "Bogdanci");
            Add(Country.MK, "601", "Bogovinje");
            Add(Country.MK, "402", "Bosilovo");
            Add(Country.MK, "602", "Brvenica");
            Add(Country.MK, "803", "Butel");
            Add(Country.MK, "814", "Centar");
            Add(Country.MK, "313", "Centar Župa");
            Add(Country.MK, "815", "Čair");
            Add(Country.MK, "109", "Čaška");
            Add(Country.MK, "210", "Češinovo-Obleševo");
            Add(Country.MK, "816", "Čučer-Sandevo");
            Add(Country.MK, "303", "Debar");
            Add(Country.MK, "304", "Debrca");
            Add(Country.MK, "203", "Delčevo");
            Add(Country.MK, "502", "Demir Hisar");
            Add(Country.MK, "103", "Demir Kapija");
            Add(Country.MK, "406", "Dojran");
            Add(Country.MK, "503", "Dolneni");
            Add(Country.MK, "804", "Gazi Baba");
            Add(Country.MK, "405", "Gevgelija");
            Add(Country.MK, "805", "Gjorče Petrov");
            Add(Country.MK, "604", "Gostivar");
            Add(Country.MK, "102", "Gradsko");
            Add(Country.MK, "807", "Ilinden");
            Add(Country.MK, "606", "Jegunovce");
            Add(Country.MK, "205", "Karbinci");
            Add(Country.MK, "808", "Karpoš");
            Add(Country.MK, "104", "Kavadarci");
            Add(Country.MK, "307", "Kičevo");
            Add(Country.MK, "809", "Kisela Voda");
            Add(Country.MK, "206", "Kočani");
            Add(Country.MK, "407", "Konče");
            Add(Country.MK, "701", "Kratovo");
            Add(Country.MK, "702", "Kriva Palanka");
            Add(Country.MK, "504", "Krivogaštani");
            Add(Country.MK, "505", "Kruševo");
            Add(Country.MK, "703", "Kumanovo");
            Add(Country.MK, "704", "Lipkovo");
            Add(Country.MK, "105", "Lozovo");
            Add(Country.MK, "207", "Makedonska Kamenica");
            Add(Country.MK, "308", "Makedonski Brod");
            Add(Country.MK, "607", "Mavrovo i Rostuše");
            Add(Country.MK, "506", "Mogila");
            Add(Country.MK, "106", "Negotino");
            Add(Country.MK, "507", "Novaci");
            Add(Country.MK, "408", "Novo Selo");
            Add(Country.MK, "310", "Ohrid");
            Add(Country.MK, "208", "Pehčevo");
            Add(Country.MK, "810", "Petrovec");
            Add(Country.MK, "311", "Plasnica");
            Add(Country.MK, "508", "Prilep");
            Add(Country.MK, "209", "Probištip");
            Add(Country.MK, "409", "Radoviš");
            Add(Country.MK, "705", "Rankovce");
            Add(Country.MK, "509", "Resen");
            Add(Country.MK, "107", "Rosoman");
            Add(Country.MK, "811", "Saraj");
            Add(Country.MK, "812", "Sopište");
            Add(Country.MK, "706", "Staro Nagoričane");
            Add(Country.MK, "312", "Struga");
            Add(Country.MK, "410", "Strumica");
            Add(Country.MK, "813", "Studeničani");
            Add(Country.MK, "108", "Sveti Nikole");
            Add(Country.MK, "211", "Štip");
            Add(Country.MK, "817", "Šuto Orizari");
            Add(Country.MK, "608", "Tearce");
            Add(Country.MK, "609", "Tetovo");
            Add(Country.MK, "403", "Valandovo");
            Add(Country.MK, "404", "Vasilevo");
            Add(Country.MK, "101", "Veles");
            Add(Country.MK, "301", "Vevčani");
            Add(Country.MK, "202", "Vinica");
            Add(Country.MK, "603", "Vrapčište");
            Add(Country.MK, "806", "Zelenikovo");
            Add(Country.MK, "204", "Zrnovci");
            Add(Country.MK, "605", "Želino");

            Debug.Assert(_subdivisionsPerCountry[Country.MK].Count == 80, "Number of subdivisions is wrong.");
        }
    }
}
