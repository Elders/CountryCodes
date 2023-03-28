using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:RS is the entry for Serbia in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Serbia, ISO 3166-2 codes are defined for two levels of subdivisions:
        ///     2 autonomous provinces
        ///     1 city and 29 districts
        /// The city Belgrade is the capital of the country and has special status equal to the districts.
        /// Each code consists of two parts, separated by a hyphen.The first part is RS, the ISO 3166-1 alpha-2 code of Serbia.The second part is either of the following:
        /// two letters: autonomous provinces
        /// two digits: city and districts
        /// The digits for the city and districts are assigned as follows:
        ///     00: city
        ///     01–07: districts in the autonomous province Vojvodina
        ///     08–24: districts in Central Serbia
        ///     25–29: districts in the autonomous province Kosovo-Metohija(different from the districts established when it was under the interim administration
        /// of the United Nations Mission in Kosovo, and currently used by the de facto independent Republic of Kosovo)
        /// Before the dissolution of Serbia and Montenegro in 2006, Serbia was assigned the ISO 3166-2 code CS-SR under the entry for Serbia and Montenegro.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:RS
        /// LastUpdated: 2023-03-21
        /// </remarks>
        internal static void ISO_3166_2_RS()
        {
            Add(Country.RS, "KM", "Kosovo-Metohija");
            Add(Country.RS, "VO", "Vojvodina");
            Add(Country.RS, "00", "Beograd");
            Add(Country.RS, "14", "Borski okrug");
            Add(Country.RS, "11", "Braničevski okrug");
            Add(Country.RS, "23", "Jablanički okrug");
            Add(Country.RS, "06", "Južnobački okrug");
            Add(Country.RS, "04", "Južnobanatski okrug");
            Add(Country.RS, "09", "Kolubarski okrug");
            Add(Country.RS, "25", "Kosovski okrug");
            Add(Country.RS, "28", "Kosovsko-Mitrovački okrug");
            Add(Country.RS, "29", "Kosovsko-Pomoravski okrug");
            Add(Country.RS, "08", "Mačvanski okrug");
            Add(Country.RS, "17", "Moravički okrug");
            Add(Country.RS, "20", "Nišavski okrug");
            Add(Country.RS, "24", "Pčinjski okrug");
            Add(Country.RS, "26", "Pećki okrug");
            Add(Country.RS, "22", "Pirotski okrug");
            Add(Country.RS, "10", "Podunavski okrug");
            Add(Country.RS, "13", "Pomoravski okrug");
            Add(Country.RS, "27", "Prizrenski okrug");
            Add(Country.RS, "19", "Rasinski okrug");
            Add(Country.RS, "18", "Raški okrug");
            Add(Country.RS, "01", "Severnobački okrug");
            Add(Country.RS, "03", "Severnobanatski okrug");
            Add(Country.RS, "02", "Srednjebanatski okrug");
            Add(Country.RS, "07", "Sremski okrug");
            Add(Country.RS, "12", "Šumadijski okrug");
            Add(Country.RS, "21", "Toplički okrug");
            Add(Country.RS, "15", "Zaječarski okrug");
            Add(Country.RS, "05", "Zapadnobački okrug");
            Add(Country.RS, "16", "Zlatiborski okrug");

            Debug.Assert(_subdivisionsPerCountry[Country.RS].Count == 32, $"{Country.RS} Number of subdivisions is wrong.");
        }
    }
}
