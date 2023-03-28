using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:ES is the entry for Spain in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Spain, ISO 3166-2 codes are defined for two levels of subdivisions:
        ///     17 autonomous communities and 2 autonomous cities in North Africa
        ///     50 provinces
        /// Each code consists of two parts, separated by a hyphen.The first part is ES, the ISO 3166-1 alpha-2 code of Spain.The second part is one or two letters.
        /// For the provinces, the letters were originally used in vehicle registration plates.The codes for the following provinces are based on the names of their capital cities rather than their own names:
        ///     Álava/Araba (ES-VI): Vitoria
        ///     Asturias(ES-O): Oviedo
        ///     Illes Balears(ES-PM) : Palma
        ///     Cantabria(ES-S): Santander
        ///     Gipuzkoa(ES-SS): San Sebastián
        ///     La Rioja(ES-LO): Logroño
        ///     Las Palmas(ES-GC) : Las Palmas de Gran Canaria
        ///     Bizkaia(ES-BI): Bilbao
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:ES
        /// LastUpdated: 2023-03-16
        /// </remarks>
        internal static void ISO_3166_2_ES()
        {
            Add(Country.ES, "AN", "Andalusia");
            Add(Country.ES, "AR", "Aragon");
            Add(Country.ES, "AS", "Principality of Asturias");
            Add(Country.ES, "CN", "anary Islands");
            Add(Country.ES, "CB", "Cantabria");
            Add(Country.ES, "CL", "Castile and León");
            Add(Country.ES, "CM", "Castile-La Mancha");
            Add(Country.ES, "CT", "atalonia");
            Add(Country.ES, "CE", "Ceuta");
            Add(Country.ES, "EX", "xtremadura");
            Add(Country.ES, "GA", "Galicia");
            Add(Country.ES, "IB", "Balearic Islands");
            Add(Country.ES, "RI", "La Rioja	La Rioja");
            Add(Country.ES, "MD", "Community of Madrid");
            Add(Country.ES, "ML", "Melilla");
            Add(Country.ES, "MC", "Region of Murcia");
            Add(Country.ES, "NC", "Chartered Community of Navarre");
            Add(Country.ES, "PV", "Basque Country");
            Add(Country.ES, "VC", "Valencian Community");
            Add(Country.ES, "C", "A Coruña");
            Add(Country.ES, "VI", "Álava");
            Add(Country.ES, "AB", "Albacete");
            Add(Country.ES, "A", "Alicante");
            Add(Country.ES, "AL", "Almería");
            Add(Country.ES, "O", "Asturias");
            Add(Country.ES, "AV", "Ávila");
            Add(Country.ES, "BA", "Badajoz");
            Add(Country.ES, "B", "Barcelona");
            Add(Country.ES, "BI", "Bizkaia");
            Add(Country.ES, "BU", "Burgos");
            Add(Country.ES, "CC", "Cáceres");
            Add(Country.ES, "CA", "Cádiz");
            Add(Country.ES, "S", "Cantabria");
            Add(Country.ES, "CS", "Castellón");
            Add(Country.ES, "CR", "Ciudad Real");
            Add(Country.ES, "CO", "Córdoba");
            Add(Country.ES, "CU", "Cuenca");
            Add(Country.ES, "SS", "Gipuzkoa");
            Add(Country.ES, "GI", "Girona");
            Add(Country.ES, "GR", "Granada");
            Add(Country.ES, "GU", "Guadalajara");
            Add(Country.ES, "H", "Huelva");
            Add(Country.ES, "HU", "Huesca");
            Add(Country.ES, "PM", "Illes Balears");
            Add(Country.ES, "J", "Jaén");
            Add(Country.ES, "LO", "La Rioja");
            Add(Country.ES, "GC", "Las Palmas");
            Add(Country.ES, "LE", "León");
            Add(Country.ES, "L", "Lleida");
            Add(Country.ES, "LU", "Lugo");
            Add(Country.ES, "M", "Madrid");
            Add(Country.ES, "MA", "Málaga");
            Add(Country.ES, "MU", "Murcia");
            Add(Country.ES, "NA", "Navarra");
            Add(Country.ES, "OR", "Ourense");
            Add(Country.ES, "P", "Palencia");
            Add(Country.ES, "PO", "Pontevedra");
            Add(Country.ES, "SA", "Salamanca");
            Add(Country.ES, "TF", "Santa Cruz de Tenerife");
            Add(Country.ES, "SG", "Segovia");
            Add(Country.ES, "SE", "Sevilla");
            Add(Country.ES, "SO", "Soria");
            Add(Country.ES, "T", "Tarragona");
            Add(Country.ES, "TE", "Teruel");
            Add(Country.ES, "TO", "Toledo");
            Add(Country.ES, "V", "Valencia");
            Add(Country.ES, "VA", "Valladolid");
            Add(Country.ES, "ZA", "Zamora");
            Add(Country.ES, "Z", "Zaragoza");

            Debug.Assert(_subdivisionsPerCountry[Country.ES].Count == 69, $"{Country.ES} Number of subdivisions is wrong.");
        }
    }
}
