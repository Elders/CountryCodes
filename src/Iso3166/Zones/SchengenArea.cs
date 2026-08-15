namespace Elders.Iso3166
{
    public partial struct EconomicZone
    {
        /// <summary>
        /// The Schengen Area abolished border checks between its members. Membership does not follow European Union membership: Ireland and Cyprus are outside it, while the four EFTA states are inside. Bulgaria and Romania became full members on 2025-01-01.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/Schengen_Area
        /// LastUpdated: 2026-08-15
        /// </remarks>
        internal static void SchengenArea()
        {
            Add("SCHENGEN", "Schengen Area", EconomicZoneType.FreeMovementArea,
                Country.AT, Country.BE, Country.BG, Country.HR, Country.CZ, Country.DK, Country.EE, Country.FI,
                Country.FR, Country.DE, Country.GR, Country.HU, Country.IT, Country.LV, Country.LT, Country.LU,
                Country.MT, Country.NL, Country.PL, Country.PT, Country.RO, Country.SK, Country.SI, Country.ES,
                Country.SE, Country.IS, Country.LI, Country.NO, Country.CH);
        }
    }
}
