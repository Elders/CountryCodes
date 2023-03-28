using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:AL is the entry for Albania in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Albania, ISO 3166-2 codes are defined for 12 counties.
        /// Each code consists of two parts, separated by a hyphen.The first part is AL, the ISO 3166-1 alpha-2 code of Albania.The second part is two digits.
        /// The codes for the counties are assigned in Albanian alphabetical order, except Dibër, whose code is assigned based on its capital, Peshkopi.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:AL
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_AL()
        {
            Add(Country.AL, "01", "Berat");
            Add(Country.AL, "09", "Dibër");
            Add(Country.AL, "02", "Durrës");
            Add(Country.AL, "03", "Elbasan");
            Add(Country.AL, "04", "Fier");
            Add(Country.AL, "05", "Gjirokastër");
            Add(Country.AL, "06", "Korçë");
            Add(Country.AL, "07", "Kukës");
            Add(Country.AL, "08", "Lezhë");
            Add(Country.AL, "10", "Shkodër");
            Add(Country.AL, "11", "Tiranë");
            Add(Country.AL, "12", "Vlorë");

            Debug.Assert(_subdivisionsPerCountry[Country.AL].Count == 12, $"{Country.AL} Number of subdivisions is wrong.");
        }
    }
}
