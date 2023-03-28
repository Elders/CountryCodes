using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:MC is the entry for Monaco in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Monaco, ISO 3166-2 codes are defined for 17 quarters.
        /// Each code consists of two parts, separated by a hyphen.The first part is MC, the ISO 3166-1 alpha-2 code of Monaco.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:MC
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_MC()
        {
            Add(Country.MC, "FO", "Fontvieille");
            Add(Country.MC, "JE", "Jardin Exotique");
            Add(Country.MC, "CL", "La Colle");
            Add(Country.MC, "CO", "La Condamine");
            Add(Country.MC, "GA", "La Gare");
            Add(Country.MC, "SO", "La Source");
            Add(Country.MC, "LA", "Larvotto");
            Add(Country.MC, "MA", "Malbousquet");
            Add(Country.MC, "MO", "Monaco-Ville");
            Add(Country.MC, "MG", "Moneghetti");
            Add(Country.MC, "MC", "Monte-Carlo");
            Add(Country.MC, "MU", "Moulins");
            Add(Country.MC, "PH", "Port-Hercule");
            Add(Country.MC, "SR", "Saint-Roman");
            Add(Country.MC, "SD", "Sainte-Dévote");
            Add(Country.MC, "SP", "Spélugues");
            Add(Country.MC, "VR", "Vallon de la Rousse");

            Debug.Assert(_subdivisionsPerCountry[Country.MC].Count == 17, $"{Country.MC} Number of subdivisions is wrong.");
        }
    }
}
