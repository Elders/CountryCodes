namespace Elders.Iso3166
{
    public partial struct EconomicZone
    {
        /// <summary>
        /// The European Union is a political and economic union of 27 member states. The United Kingdom withdrew in 2020.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/Member_state_of_the_European_Union
        /// LastUpdated: 2026-08-15
        /// </remarks>
        internal static void EuropeanUnion()
        {
            Add("EU", "European Union", EconomicZoneType.EconomicUnion,
                Country.AT, Country.BE, Country.BG, Country.HR, Country.CY, Country.CZ, Country.DK, Country.EE,
                Country.FI, Country.FR, Country.DE, Country.GR, Country.HU, Country.IE, Country.IT, Country.LV,
                Country.LT, Country.LU, Country.MT, Country.NL, Country.PL, Country.PT, Country.RO, Country.SK,
                Country.SI, Country.ES, Country.SE);
        }
    }
}
