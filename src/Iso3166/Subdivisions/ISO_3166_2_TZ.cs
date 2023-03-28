using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:TZ is the entry for Tanzania in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Tanzania, ISO 3166-2 codes are defined for 31 regions.
        /// Each code consists of two parts, separated by a hyphen.The first part is TZ, the ISO 3166-1 alpha-2 code of Tanzania.The second part is two digits:
        ///     01–25: regions as of early 2000s
        ///     26: region created in 2002
        ///     27-30: regions created in 2012
        ///     31: region created in 2016
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:TZ
        /// LastUpdated: 2023-03-20
        /// </remarks>
        internal static void ISO_3166_2_TZ()
        {
            Add(Country.TZ, "01", "Arusha");
            Add(Country.TZ, "02", "Dar es Salaam");
            Add(Country.TZ, "03", "Dodoma");
            Add(Country.TZ, "27", "Geita");
            Add(Country.TZ, "04", "Iringa");
            Add(Country.TZ, "05", "Kagera");
            Add(Country.TZ, "06", "Kaskazini Pemba");
            Add(Country.TZ, "07", "Kaskazini Unguja");
            Add(Country.TZ, "28", "Katavi");
            Add(Country.TZ, "08", "Kigoma");
            Add(Country.TZ, "09", "Kilimanjaro");
            Add(Country.TZ, "10", "Kusini Pemba");
            Add(Country.TZ, "11", "Kusini Unguja");
            Add(Country.TZ, "12", "Lindi");
            Add(Country.TZ, "26", "Manyara");
            Add(Country.TZ, "13", "Mara");
            Add(Country.TZ, "14", "Mbeya");
            Add(Country.TZ, "15", "Mjini Magharibi");
            Add(Country.TZ, "16", "Morogoro");
            Add(Country.TZ, "17", "Mtwara");
            Add(Country.TZ, "18", "Mwanza");
            Add(Country.TZ, "29", "Njombe");
            Add(Country.TZ, "19", "Pwani");
            Add(Country.TZ, "20", "Rukwa");
            Add(Country.TZ, "21", "Ruvuma");
            Add(Country.TZ, "22", "Shinyanga");
            Add(Country.TZ, "30", "Simiyu");
            Add(Country.TZ, "23", "Singida");
            Add(Country.TZ, "31", "Songwe");
            Add(Country.TZ, "24", "Tabora");
            Add(Country.TZ, "25", "Tanga");

            Debug.Assert(_subdivisionsPerCountry[Country.TZ].Count == 31, $"{Country.TZ} Number of subdivisions is wrong.");
        }
    }
}
