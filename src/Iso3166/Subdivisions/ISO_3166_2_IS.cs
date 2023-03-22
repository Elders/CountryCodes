using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:IS is the entry for Iceland in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Iceland, ISO 3166-2 codes are defined for 8 regions and 64 municipalities.
        /// Each code consists of two parts, separated by a hyphen.The first part is IS,
        /// the ISO 3166-1 alpha-2 code of Iceland and the second part is a digit(1–8) for regions or three letters for municipalities.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:IS
        /// LastUpdated: 2023-03-16
        /// </remarks>
        internal static void ISO_3166_2_IS()
        {
            Add(Country.IS, "1", "Höfuðborgarsvæði");
            Add(Country.IS, "2", "Suðurnes");
            Add(Country.IS, "3", "Vesturland");
            Add(Country.IS, "4", "Vestfirðir");
            Add(Country.IS, "5", "Norðurland vestra");
            Add(Country.IS, "6", "Norðurland eystra");
            Add(Country.IS, "7", "Austurland");
            Add(Country.IS, "8", "Suðurland");
            Add(Country.IS, "AKN", "Akraneskaupstaður");
            Add(Country.IS, "AKU", "Akureyrarbær");
            Add(Country.IS, "ARN", "Árneshreppur");
            Add(Country.IS, "ASA", "Ásahreppur");
            Add(Country.IS, "BLA", "Bláskógabyggð");
            Add(Country.IS, "BOG", "Borgarbyggð");
            Add(Country.IS, "BOL", "Bolungarvíkurkaupstaður");
            Add(Country.IS, "DAB", "Dalabyggð");
            Add(Country.IS, "DAV", "Dalvíkurbyggð");
            Add(Country.IS, "EOM", "Eyja- og Miklaholtshreppur");
            Add(Country.IS, "EYF", "Eyjafjarðarsveit");
            Add(Country.IS, "FJD", "Fjarðabyggð");
            Add(Country.IS, "FJL", "Fjallabyggð");
            Add(Country.IS, "FLA", "Flóahreppur");
            Add(Country.IS, "FLR", "Fljótsdalshreppur");
            Add(Country.IS, "GAR", "Garðabær");
            Add(Country.IS, "GOG", "Grímsnes- og Grafningshreppur");
            Add(Country.IS, "GRN", "Grindavíkurbær");
            Add(Country.IS, "GRU", "Grundarfjarðarbær");
            Add(Country.IS, "GRY", "Grýtubakkahreppur");
            Add(Country.IS, "HAF", "Hafnarfjarðarkaupstaður");
            Add(Country.IS, "HRG", "Hörgársveit");
            Add(Country.IS, "HRU", "Hrunamannahreppur");
            Add(Country.IS, "HUG", "Húnabyggð");
            Add(Country.IS, "HUV", "Húnaþing vestra");
            Add(Country.IS, "HVA", "Hvalfjarðarsveit");
            Add(Country.IS, "HVE", "Hveragerðisbær");
            Add(Country.IS, "ISA", "Ísafjarðarbær");
            Add(Country.IS, "KAL", "Kaldrananeshreppur");
            Add(Country.IS, "KJO", "Kjósarhreppur");
            Add(Country.IS, "KOP", "Kópavogsbær");
            Add(Country.IS, "LAN", "Langanesbyggð");
            Add(Country.IS, "MOS", "Mosfellsbær");
            Add(Country.IS, "MUL", "Múlaþing");
            Add(Country.IS, "MYR", "Mýrdalshreppur");
            Add(Country.IS, "NOR", "Norðurþing");
            Add(Country.IS, "RGE", "Rangárþing eystra");
            Add(Country.IS, "RGY", "Rangárþing ytra");
            Add(Country.IS, "RHH", "Reykhólahreppur");
            Add(Country.IS, "RKN", "Reykjanesbær");
            Add(Country.IS, "RKV", "Reykjavíkurborg");
            Add(Country.IS, "SBT", "Svalbarðsstrandarhreppur");
            Add(Country.IS, "SDN", "Suðurnesjabær");
            Add(Country.IS, "SDV", "Súðavíkurhreppur");
            Add(Country.IS, "SEL", "Seltjarnarnesbær");
            Add(Country.IS, "SFA", "Sveitarfélagið Árborg");
            Add(Country.IS, "SHF", "Sveitarfélagið Hornafjörður");
            Add(Country.IS, "SKF", "Skaftárhreppur");
            Add(Country.IS, "SKG", "Skagabyggð");
            Add(Country.IS, "SKO", "Skorradalshreppur");
            Add(Country.IS, "SKR", "Skagafjörður");
            Add(Country.IS, "SNF", "Snæfellsbær");
            Add(Country.IS, "SOG", "Skeiða- og Gnúpverjahreppur");
            Add(Country.IS, "SOL", "Sveitarfélagið Ölfus");
            Add(Country.IS, "SSS", "Sveitarfélagið Skagaströnd");
            Add(Country.IS, "STR", "Strandabyggð");
            Add(Country.IS, "STY", "Stykkishólmsbær");
            Add(Country.IS, "SVG", "Sveitarfélagið Vogar");
            Add(Country.IS, "TAL", "Tálknafjarðarhreppur");
            Add(Country.IS, "THG", "Þingeyjarsveit");
            Add(Country.IS, "TJO", "Tjörneshreppur");
            Add(Country.IS, "VEM", "Vestmannaeyjabær");
            Add(Country.IS, "VER", "Vesturbyggð");
            Add(Country.IS, "VOP", "Vopnafjarðarhreppur");

            Debug.Assert(_subdivisionsPerCountry[Country.IS].Count == 72, "Number of subdivisions is wrong.");
        }
    }
}
