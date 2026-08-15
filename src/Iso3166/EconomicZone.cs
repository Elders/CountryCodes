using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;

namespace Elders.Iso3166
{
    /// <summary>
    /// Represents a group of countries bound by an economic, customs, monetary or free-movement arrangement.
    /// The zones overlap but are not interchangeable: Ireland and Cyprus are in the European Union but not in
    /// Schengen, Switzerland is in Schengen and EFTA but in neither the European Union nor the European Economic
    /// Area, and six European Union members do not use the euro. <see cref="EconomicZoneType"/> records which
    /// kind of arrangement each zone is.
    /// </summary>
    /// <remarks>
    ///     Unlike <see cref="Country"/> this is not an ISO standard. Membership is political, changes over time
    ///     and carries no external identifier, so each zone is listed by hand in its own file under Zones and
    ///     records the date it was last verified.
    ///     Zones are modelled per country, which is why arrangements defined at territory level, such as the
    ///     European Union VAT area and customs territory, are absent rather than approximated.
    /// </remarks>
    [Serializable]
    [DataContract(Name = "economic-zone")]
    public partial struct EconomicZone : IEquatable<EconomicZone>
    {
        private static readonly Dictionary<string, ZoneTableEntry> _allZones = new Dictionary<string, ZoneTableEntry>(StringComparer.Ordinal);
        private static readonly Dictionary<string, string> _canonicalCodes = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        private static readonly Dictionary<int, ReadOnlyCollection<EconomicZone>> _zonesPerCountry = new Dictionary<int, ReadOnlyCollection<EconomicZone>>();
        private static readonly ReadOnlyCollection<EconomicZone> _noZones = new ReadOnlyCollection<EconomicZone>(Array.Empty<EconomicZone>());
        private static readonly ReadOnlyCollection<EconomicZone> _allZonesList;

        [DataMember(Order = 0)]
        private string _code;

        static EconomicZone()
        {
            EuropeanUnion();
            EuroArea();
            EuropeanEconomicArea();
            EuropeanFreeTradeAssociation();
            SchengenArea();
            UnitedStatesMexicoCanadaAgreement();
            GulfCooperationCouncil();
            GroupOfSeven();

            EU = new EconomicZone("EU");
            EA = new EconomicZone("EA");
            EEA = new EconomicZone("EEA");
            EFTA = new EconomicZone("EFTA");
            SCHENGEN = new EconomicZone("SCHENGEN");
            USMCA = new EconomicZone("USMCA");
            GCC = new EconomicZone("GCC");
            G7 = new EconomicZone("G7");

            _allZonesList = new ReadOnlyCollection<EconomicZone>(_allZones.Keys.Select(x => new EconomicZone(x)).ToArray());

            var zonesPerCountry = new Dictionary<int, List<EconomicZone>>();
            foreach (var entry in _allZones.Values)
            {
                var zone = new EconomicZone(entry._code);
                foreach (var member in entry._members)
                {
                    if (zonesPerCountry.TryGetValue(member.NumericCode, out List<EconomicZone> zones) == false)
                    {
                        zones = new List<EconomicZone>();
                        zonesPerCountry.Add(member.NumericCode, zones);
                    }

                    zones.Add(zone);
                }
            }

            foreach (var pair in zonesPerCountry)
            {
                _zonesPerCountry.Add(pair.Key, new ReadOnlyCollection<EconomicZone>(pair.Value.ToArray()));
            }
        }

        internal static void Add(string code, string name, EconomicZoneType type, params Country[] members)
        {
            var entry = new ZoneTableEntry(code, name, type, members);

            _allZones.Add(code, entry);
            _canonicalCodes.Add(code, code);
        }

        #region Zones

        public static readonly EconomicZone EU;
        public static readonly EconomicZone EA;
        public static readonly EconomicZone EEA;
        public static readonly EconomicZone EFTA;
        public static readonly EconomicZone SCHENGEN;
        public static readonly EconomicZone USMCA;
        public static readonly EconomicZone GCC;
        public static readonly EconomicZone G7;

        #endregion

        public EconomicZone() { _code = null; }

        public EconomicZone(string code)
        {
            if (code is null)
                throw new ArgumentNullException(nameof(code));

            if (_canonicalCodes.TryGetValue(code.Trim(), out string canonical) == false)
                throw new ArgumentException($"Invalid economic zone code {code}", nameof(code));

            _code = canonical;
        }

        /// <summary>
        /// Short code identifying the zone, for example "EU".
        /// </summary>
        public readonly string Code => GetEntry(_code)._code;

        /// <summary>
        /// Full name of the zone, for example "European Union".
        /// </summary>
        public readonly string Name => GetEntry(_code)._name;

        /// <summary>
        /// The kind of arrangement the zone represents. A monetary union and a free-movement area can cover
        /// nearly the same countries while meaning entirely different things.
        /// </summary>
        public readonly EconomicZoneType Type => GetEntry(_code)._type;

        /// <summary>
        /// The countries that belong to the zone.
        /// </summary>
        public readonly ReadOnlyCollection<Country> Members => GetEntry(_code)._members;

        /// <summary>
        /// Whether the given country belongs to the zone. Membership is held as a lookup indexed by ISO 3166-1
        /// numeric code, so this neither hashes nor allocates.
        /// </summary>
        public readonly bool Contains(Country country)
        {
            bool[] membership = GetEntry(_code)._membership;
            int numericCode = country.NumericCode;

            return numericCode < membership.Length && membership[numericCode];
        }

        public static IEnumerable<EconomicZone> GetAllZones() => _allZonesList;

        /// <summary>
        /// Every zone the given country belongs to. The result is precomputed, so it neither scans nor allocates.
        /// </summary>
        public static ReadOnlyCollection<EconomicZone> GetZonesOf(Country country) => _zonesPerCountry.TryGetValue(country.NumericCode, out ReadOnlyCollection<EconomicZone> zones) ? zones : _noZones;

        public static bool TryParse(string code, out EconomicZone zone)
        {
            if (code is not null && _canonicalCodes.TryGetValue(code.Trim(), out string canonical))
            {
                zone = new EconomicZone(canonical);
                return true;
            }

            zone = default;
            return false;
        }

        private static ZoneTableEntry GetEntry(string code)
        {
            if (code is null)
                throw new ArgumentException($"Unknown economic zone: {code}");

            if (_allZones.TryGetValue(code, out ZoneTableEntry entry))
                return entry;

            if (_canonicalCodes.TryGetValue(code, out string canonical) && _allZones.TryGetValue(canonical, out entry))
                return entry;

            throw new ArgumentException($"Unknown economic zone: {code}");
        }

        public static bool operator ==(EconomicZone left, EconomicZone right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(EconomicZone left, EconomicZone right)
        {
            return left.Equals(right) == false;
        }

        public override readonly bool Equals(object obj)
        {
            if (obj is EconomicZone other)
                return Equals(other);

            return false;
        }

        public readonly bool Equals(EconomicZone other)
        {
            return ReferenceEquals(_code, other._code) || string.Equals(_code, other._code, StringComparison.OrdinalIgnoreCase);
        }

        public override readonly int GetHashCode()
        {
            unchecked
            {
                return (_code is null ? 0 : StringComparer.OrdinalIgnoreCase.GetHashCode(_code)) ^ 7883;
            }
        }

        public override readonly string ToString() => _code;

        private readonly struct ZoneTableEntry
        {
            internal readonly string _code;
            internal readonly string _name;
            internal readonly EconomicZoneType _type;
            internal readonly ReadOnlyCollection<Country> _members;
            internal readonly bool[] _membership;

            public ZoneTableEntry(string code, string name, EconomicZoneType type, Country[] members)
            {
                _code = code;
                _name = name;
                _type = type;
                _members = new ReadOnlyCollection<Country>(members);

                int highest = 0;
                foreach (var member in members)
                {
                    if (member.NumericCode > highest)
                        highest = member.NumericCode;
                }

                _membership = new bool[highest + 1];
                foreach (var member in members)
                {
                    _membership[member.NumericCode] = true;
                }
            }
        }
    }
}
