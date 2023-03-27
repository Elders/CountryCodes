using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:DO is the entry for the Dominican Republic in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for the Dominican Republic, ISO 3166-2 codes are defined for 10 regions, 31 provinces and 1 district.
        /// The Distrito Nacional contains the capital of the country Santo Domingo and has special status equal to the provinces.
        /// Each code consists of two parts, separated by a hyphen.The first part is DO, the ISO 3166-1 alpha-2 code of the Dominican Republic.The second part is two digits:
        ///     01: district
        ///     02–27: provinces as of late 1970s
        ///     28–30: provinces created in the 1980s and 1990s
        ///     31–32: provinces created in 2001 and 2002
        ///     33–42: regions
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:DO
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_DO()
        {
            Add(Country.DO, "01", "Distrito Nacional");
            Add(Country.DO, "02", "Azua");
            Add(Country.DO, "03", "Baoruco");
            Add(Country.DO, "04", "Barahona");
            Add(Country.DO, "05", "Dajabón");
            Add(Country.DO, "06", "Duarte");
            Add(Country.DO, "08", "El Seibo");
            Add(Country.DO, "09", "Espaillat");
            Add(Country.DO, "30", "Hato Mayor");
            Add(Country.DO, "10", "Independencia");
            Add(Country.DO, "11", "La Altagracia");
            Add(Country.DO, "07", "Elías Piña");
            Add(Country.DO, "12", "La Romana");
            Add(Country.DO, "13", "La Vega");
            Add(Country.DO, "14", "María Trinidad Sánchez");
            Add(Country.DO, "28", "Monseñor Nouel");
            Add(Country.DO, "15", "Monte Cristi");
            Add(Country.DO, "29", "Monte Plata");
            Add(Country.DO, "16", "Pedernales");
            Add(Country.DO, "17", "Peravia");
            Add(Country.DO, "18", "Puerto Plata");
            Add(Country.DO, "19", "Hermanas Mirabal");
            Add(Country.DO, "20", "Samaná");
            Add(Country.DO, "21", "San Cristóbal");
            Add(Country.DO, "31", "San José de Ocoa");
            Add(Country.DO, "22", "San Juan");
            Add(Country.DO, "23", "San Pedro de Macorís");
            Add(Country.DO, "24", "Sánchez Ramírez");
            Add(Country.DO, "25", "Santiago");
            Add(Country.DO, "26", "Santiago Rodríguez");
            Add(Country.DO, "32", "Santo Domingo");
            Add(Country.DO, "27", "Valverde");
            Add(Country.DO, "33", "Cibao Nordeste");
            Add(Country.DO, "34", "Cibao Noroeste");
            Add(Country.DO, "35", "Cibao Norte");
            Add(Country.DO, "36", "Cibao Sur");
            Add(Country.DO, "37", "El Valle");
            Add(Country.DO, "38", "Enriquillo");
            Add(Country.DO, "39", "Higuamo");
            Add(Country.DO, "40", "Ozama");
            Add(Country.DO, "41", "Valdesia");
            Add(Country.DO, "42", "Yuma");

            Debug.Assert(_subdivisionsPerCountry[Country.DO].Count == 42, "Number of subdivisions is wrong.");
        }
    }
}
