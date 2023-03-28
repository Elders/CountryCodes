using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:EH is the entry for Western Sahara in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently no ISO 3166-2 codes are defined in the entry for Western Sahara.
        /// Western Sahara, a disputed territory de facto controlled by Morocco and claimed by the Sahrawi Arab Democratic Republic,
        /// is officially assigned the ISO 3166-1 alpha-2 code EH. Moreover, the following regions, provinces and prefectures of Morocco located in the territory
        /// of Western Sahara are assigned ISO 3166-2 codes under the entry for Morocco:
        ///     MA-12 Dakhla-Oued Ed-Dahab (entirely in Western Sahara)
        ///         MA-AOU Aousserd(entirely in Western Sahara)
        ///         MA-OUD Oued Ed-Dahab(entirely in Western Sahara)
        ///     MA-10 Guelmim-Oued Noun(partially in Western Sahara)
        ///         MA-ASZ Assa-Zag(partially in Western Sahara)
        ///         MA-TNT Tan-Tan(partially in Western Sahara)
        ///     MA-11 Laâyoune-Sakia El Hamra(partially in Western Sahara)
        ///         MA-BOD Boujdour(entirely in Western Sahara)
        ///         MA-ESM Es-Semara(partially in Western Sahara)
        ///         MA-LAA Laâyoune(entirely in Western Sahara)
        ///         MA-TAF Tarfaya(partially in Western Sahara)
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:EH
        /// LastUpdated: 2023-03-26
        /// </remarks>
        internal static void ISO_3166_2_EH()
        {
            Debug.Assert(_subdivisionsPerCountry.ContainsKey(Country.EH) == false, $"{Country.EH} Number of subdivisions is wrong.");
        }
    }
}
