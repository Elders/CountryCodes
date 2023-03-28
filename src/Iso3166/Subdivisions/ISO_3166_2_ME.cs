using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:ME is the entry for Montenegro in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Montenegro, ISO 3166-2 codes are defined for 24 municipalities.
        /// Each code consists of two parts, separated by a hyphen.The first part is ME, the ISO 3166-1 alpha-2 code of Montenegro.The second part is two digits(01–24).
        /// Before the dissolution of Serbia and Montenegro in 2006, Montenegro was assigned the ISO 3166-2 code CS-CG under the entry for Serbia and Montenegro.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:ME
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_ME()
        {
            Add(Country.ME, "01", "Andrijevica");
            Add(Country.ME, "02", "Bar");
            Add(Country.ME, "03", "Berane");
            Add(Country.ME, "04", "Bijelo Polje");
            Add(Country.ME, "05", "Budva");
            Add(Country.ME, "06", "Cetinje");
            Add(Country.ME, "07", "Danilovgrad");
            Add(Country.ME, "08", "Herceg-Novi");
            Add(Country.ME, "09", "Kolašin");
            Add(Country.ME, "10", "Kotor");
            Add(Country.ME, "11", "Mojkovac");
            Add(Country.ME, "12", "Nikšić");
            Add(Country.ME, "13", "Plav");
            Add(Country.ME, "14", "Pljevlja");
            Add(Country.ME, "15", "Plužine");
            Add(Country.ME, "16", "Podgorica");
            Add(Country.ME, "17", "Rožaje");
            Add(Country.ME, "18", "Šavnik");
            Add(Country.ME, "19", "Tivat");
            Add(Country.ME, "20", "Ulcinj");
            Add(Country.ME, "21", "Žabljak");
            Add(Country.ME, "22", "Gusinje");
            Add(Country.ME, "23", "Petnjica");
            Add(Country.ME, "24", "Tuzi");

            Debug.Assert(_subdivisionsPerCountry[Country.ME].Count == 24, $"{Country.ME} Number of subdivisions is wrong.");
        }
    }
}
