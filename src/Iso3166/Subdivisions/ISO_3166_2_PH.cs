using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:PH is the entry for the Philippines in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for the Philippines, ISO 3166-2 codes are defined for two levels of subdivisions:
        ///     17 regions
        ///     81 provinces
        /// Each code consists of two parts, separated by a hyphen.The first part is PH, the ISO 3166-1 alpha-2 code of the Philippines. The second part is either of the following:
        ///     two digits: regions
        ///     three letters: provinces
        /// The codes for the regions correspond to the Roman numerals used to represent the regions, except the Autonomous Region in Muslim Mindanao, the Cordillera Administrative Region, Mimaropa, and the National Capital Region,
        /// which do not use Roman numerals for representation purposes.
        /// The codes for the provinces of Cotabato (PH-NCO) and Davao de Oro(PH-COM) are assigned based on their former names, North Cotabato and Compostela Valley respectively.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:PH
        /// LastUpdated: 2023-03-21
        /// </remarks>
        internal static void ISO_3166_2_PH()
        {
            Add(Country.PH, "14", "Autonomous Region in Muslim Mindanao");
            Add(Country.PH, "05", "Bicol");
            Add(Country.PH, "02", "Cagayan Valley");
            Add(Country.PH, "40", "Calabarzon");
            Add(Country.PH, "13", "Caraga");
            Add(Country.PH, "03", "Central Luzon");
            Add(Country.PH, "07", "Central Visayas");
            Add(Country.PH, "15", "Cordillera Administrative Region");
            Add(Country.PH, "11", "Davao");
            Add(Country.PH, "08", "Eastern Visayas");
            Add(Country.PH, "01", "Ilocos");
            Add(Country.PH, "41", "Mimaropa");
            Add(Country.PH, "00", "National Capital Region");
            Add(Country.PH, "10", "Northern Mindanao");
            Add(Country.PH, "12", "Soccsksargen");
            Add(Country.PH, "06", "Western Visayas");
            Add(Country.PH, "09", "Zamboanga Peninsula");
            Add(Country.PH, "ABR", "Abra");
            Add(Country.PH, "AGN", "Agusan del Norte");
            Add(Country.PH, "AGS", "Agusan del Sur");
            Add(Country.PH, "AKL", "Aklan");
            Add(Country.PH, "ALB", "Albay");
            Add(Country.PH, "ANT", "Antique");
            Add(Country.PH, "APA", "Apayao");
            Add(Country.PH, "AUR", "Aurora");
            Add(Country.PH, "BAS", "Basilan");
            Add(Country.PH, "BAN", "Bataan");
            Add(Country.PH, "BTN", "Batanes");
            Add(Country.PH, "BTG", "Batangas");
            Add(Country.PH, "BEN", "Benguet");
            Add(Country.PH, "BIL", "Biliran");
            Add(Country.PH, "BOH", "Bohol");
            Add(Country.PH, "BUK", "Bukidnon");
            Add(Country.PH, "BUL", "Bulacan");
            Add(Country.PH, "CAG", "Cagayan");
            Add(Country.PH, "CAN", "Camarines Norte");
            Add(Country.PH, "CAS", "Camarines Sur");
            Add(Country.PH, "CAM", "Camiguin");
            Add(Country.PH, "CAP", "Capiz");
            Add(Country.PH, "CAT", "Catanduanes");
            Add(Country.PH, "CAV", "Cavite");
            Add(Country.PH, "CEB", "Cebu");
            Add(Country.PH, "NCO", "Cotabato");
            Add(Country.PH, "COM", "Davao de Oro");
            Add(Country.PH, "DAV", "Davao del Norte");
            Add(Country.PH, "DAS", "Davao del Sur");
            Add(Country.PH, "DVO", "Davao Occidental");
            Add(Country.PH, "DAO", "Davao Oriental");
            Add(Country.PH, "DIN", "Dinagat Islands");
            Add(Country.PH, "EAS", "Eastern Samar");
            Add(Country.PH, "GUI", "Guimaras");
            Add(Country.PH, "IFU", "Ifugao");
            Add(Country.PH, "ILN", "Ilocos Norte");
            Add(Country.PH, "ILS", "Ilocos Sur");
            Add(Country.PH, "ILI", "Iloilo");
            Add(Country.PH, "ISA", "Isabela");
            Add(Country.PH, "KAL", "Kalinga");
            Add(Country.PH, "LUN", "La Union");
            Add(Country.PH, "LAG", "Laguna");
            Add(Country.PH, "LAN", "Lanao del Norte");
            Add(Country.PH, "LAS", "Lanao del Sur");
            Add(Country.PH, "LEY", "Leyte	Le");
            Add(Country.PH, "MAG", "Maguindanao");
            Add(Country.PH, "MAD", "Marinduque");
            Add(Country.PH, "MAS", "Masbate");
            Add(Country.PH, "MDC", "Mindoro Occidental");
            Add(Country.PH, "MDR", "Mindoro Oriental");
            Add(Country.PH, "MSC", "Misamis Occidental");
            Add(Country.PH, "MSR", "Misamis Oriental");
            Add(Country.PH, "MOU", "Mountain Province");
            Add(Country.PH, "NEC", "Negros Occidental");
            Add(Country.PH, "NER", "Negros Oriental");
            Add(Country.PH, "NSA", "Northern Samar");
            Add(Country.PH, "NUE", "Nueva Ecija");
            Add(Country.PH, "NUV", "Nueva Vizcaya");
            Add(Country.PH, "PLW", "Palawan");
            Add(Country.PH, "PAM", "Pampanga");
            Add(Country.PH, "PAN", "Pangasinan");
            Add(Country.PH, "QUE", "Quezon");
            Add(Country.PH, "QUI", "Quirino");
            Add(Country.PH, "RIZ", "Rizal");
            Add(Country.PH, "ROM", "Romblon");
            Add(Country.PH, "WSA", "Samar");
            Add(Country.PH, "SAR", "Sarangani");
            Add(Country.PH, "SIG", "Siquijor");
            Add(Country.PH, "SOR", "Sorsogon");
            Add(Country.PH, "SCO", "South Cotabato");
            Add(Country.PH, "SLE", "Southern Leyte");
            Add(Country.PH, "SUK", "Sultan Kudarat");
            Add(Country.PH, "SLU", "Sulu");
            Add(Country.PH, "SUN", "Surigao del Norte");
            Add(Country.PH, "SUR", "Surigao del Sur");
            Add(Country.PH, "TAR", "Tarlac");
            Add(Country.PH, "TAW", "Tawi-Tawi");
            Add(Country.PH, "ZMB", "Zambales");
            Add(Country.PH, "ZAN", "Zamboanga del Norte");
            Add(Country.PH, "ZAS", "Zamboanga del Sur");
            Add(Country.PH, "ZSI", "Zamboanga Sibugay");

            Debug.Assert(_subdivisionsPerCountry[Country.PH].Count == 98, $"{Country.PH} Number of subdivisions is wrong.");
        }
    }
}
