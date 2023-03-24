using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:IR is the entry for the Islamic Republic of Iran in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Iran, ISO 3166-2 codes are defined for 31 provinces.
        /// Each code consists of two parts, separated by a hyphen.The first part is IR, the ISO 3166-1 alpha-2 code of Iran.The second part is two digits.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:IR
        /// LastUpdated: 2023-03-23
        /// </remarks>
        internal static void ISO_3166_2_IR()
        {
            Add(Country.IR, "30", "Alborz");
            Add(Country.IR, "24", "Ardabīl");
            Add(Country.IR, "04", "Āz̄ārbāyjān-e Ghārbī");
            Add(Country.IR, "03", "Āz̄ārbāyjān-e Shārqī");
            Add(Country.IR, "18", "Būshehr");
            Add(Country.IR, "14", "Chahār Maḩāl va Bakhtīārī");
            Add(Country.IR, "10", "Eşfahān");
            Add(Country.IR, "07", "Fārs");
            Add(Country.IR, "01", "Gīlān");
            Add(Country.IR, "27", "Golestān");
            Add(Country.IR, "13", "Hamadān");
            Add(Country.IR, "22", "Hormozgān");
            Add(Country.IR, "16", "Īlām");
            Add(Country.IR, "08", "Kermān");
            Add(Country.IR, "05", "Kermānshāh");
            Add(Country.IR, "29", "Khorāsān-e Jonūbī");
            Add(Country.IR, "09", "Khorāsān-e Raẕavī");
            Add(Country.IR, "28", "Khorāsān-e Shomālī");
            Add(Country.IR, "06", "Khūzestān");
            Add(Country.IR, "17", "Kohgīlūyeh va Bowyer Aḩmad");
            Add(Country.IR, "12", "Kordestān");
            Add(Country.IR, "15", "Lorestān");
            Add(Country.IR, "00", "Markazī");
            Add(Country.IR, "02", "Māzandarān");
            Add(Country.IR, "26", "Qazvīn");
            Add(Country.IR, "25", "Qom");
            Add(Country.IR, "20", "Semnān");
            Add(Country.IR, "11", "Sīstān va Balūchestān");
            Add(Country.IR, "23", "Tehrān");
            Add(Country.IR, "21", "Yazd");
            Add(Country.IR, "19", "Zanjān");

            Debug.Assert(_subdivisionsPerCountry[Country.IR].Count == 31, "Number of subdivisions is wrong.");
        }
    }
}
