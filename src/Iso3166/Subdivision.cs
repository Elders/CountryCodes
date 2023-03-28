using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace Elders.Iso3166
{
    /// <summary>
    /// Subdivisions as described in ISO 3166-2.
    /// The purpose of ISO 3166-2 is to establish an international standard of short and unique alphanumeric codes to represent the relevant administrative
    /// divisions and dependent territories of all countries in a more convenient and less ambiguous form than their full names. Each complete ISO 3166-2 code
    /// consists of two parts, separated by a hyphen. The first part is the ISO 3166-1 alpha-2 code of the country. The second part is a string of up to three
    /// alphanumeric characters, which is usually obtained from national sources and stems from coding systems already in use in the country concerned,
    /// but may also be developed by the ISO itself.
    /// </summary>
    /// <remarks>
    ///     The ISO 3166-2 gives the freedom to have milti-level hierarhy for subdivisions in each country. The <see cref="Subdivision"/> uses a flat structure only
    ///     because there is no standard defined for this.
    /// </remarks>
    [Serializable]
    [DataContract(Name = "iso-3166-subdivision")]
    public partial struct Subdivision : IEquatable<Subdivision>
    {
        private static ICollection<Subdivision> _subdivisions = new List<Subdivision>();

        private static readonly Dictionary<int, SubdivisionTableEntry> _allSubdivisions = new Dictionary<int, SubdivisionTableEntry>();
        private static readonly Dictionary<Country, List<Subdivision>> _subdivisionsPerCountry = new Dictionary<Country, List<Subdivision>>();

        [DataMember(Order = 0)]
        private int _subdivisionId;

        public int Id => _subdivisionId;

        static Subdivision()
        {
            ISO_3166_2_AF();
            ISO_3166_2_AX();
            ISO_3166_2_AL();
            ISO_3166_2_DZ();
            ISO_3166_2_AS();
            ISO_3166_2_AD();
            ISO_3166_2_AO();
            ISO_3166_2_AI();
            ISO_3166_2_AQ();
            ISO_3166_2_AG();
            ISO_3166_2_AR();
            ISO_3166_2_AM();
            ISO_3166_2_AW();
            ISO_3166_2_AU();
            ISO_3166_2_AT();
            ISO_3166_2_AZ();
            ISO_3166_2_BS();
            ISO_3166_2_BH();
            ISO_3166_2_BD();
            ISO_3166_2_BB();
            ISO_3166_2_BY();
            ISO_3166_2_BE();
            ISO_3166_2_BZ();
            ISO_3166_2_BJ();
            ISO_3166_2_BM();
            ISO_3166_2_BT();
            ISO_3166_2_BO();
            ISO_3166_2_BQ();
            ISO_3166_2_BA();
            ISO_3166_2_BW();
            ISO_3166_2_BV();
            ISO_3166_2_BR();
            ISO_3166_2_IO();
            ISO_3166_2_BN();
            ISO_3166_2_BG();
            ISO_3166_2_BF();
            ISO_3166_2_BI();
            ISO_3166_2_KH();
            ISO_3166_2_CM();
            ISO_3166_2_CA();
            ISO_3166_2_CV();
            ISO_3166_2_KY();
            ISO_3166_2_CF();
            ISO_3166_2_TD();
            ISO_3166_2_CL();
            ISO_3166_2_CN();
            ISO_3166_2_CX();
            ISO_3166_2_CC();
            ISO_3166_2_CO();
            ISO_3166_2_KM();
            ISO_3166_2_CG();
            ISO_3166_2_CD();
            ISO_3166_2_CK();
            ISO_3166_2_CR();
            ISO_3166_2_CI();
            ISO_3166_2_HR();
            ISO_3166_2_CU();
            ISO_3166_2_CW();
            ISO_3166_2_CY();
            ISO_3166_2_CZ();
            ISO_3166_2_DK();
            ISO_3166_2_DJ();
            ISO_3166_2_DM();
            ISO_3166_2_DO();
            ISO_3166_2_EC();
            ISO_3166_2_EG();
            ISO_3166_2_SV();
            ISO_3166_2_GQ();
            ISO_3166_2_ER();
            ISO_3166_2_EE();
            ISO_3166_2_ET();
            ISO_3166_2_FK();
            ISO_3166_2_FO();
            ISO_3166_2_FJ();
            ISO_3166_2_FI();
            ISO_3166_2_FR();
            ISO_3166_2_GF();
            ISO_3166_2_PF();
            ISO_3166_2_TF();
            ISO_3166_2_GA();
            ISO_3166_2_GM();
            ISO_3166_2_GE();
            ISO_3166_2_DE();
            ISO_3166_2_GH();
            ISO_3166_2_GI();
            ISO_3166_2_GR();
            ISO_3166_2_GL();
            ISO_3166_2_GD();
            ISO_3166_2_GP();
            ISO_3166_2_GU();
            ISO_3166_2_GT();
            ISO_3166_2_GG();
            ISO_3166_2_GN();
            ISO_3166_2_GW();
            ISO_3166_2_GY();
            ISO_3166_2_HT();
            ISO_3166_2_HM();
            ISO_3166_2_VA();
            ISO_3166_2_HN();
            ISO_3166_2_HK();
            ISO_3166_2_HU();
            ISO_3166_2_IS();
            ISO_3166_2_IN();
            ISO_3166_2_ID();
            ISO_3166_2_IR();
            ISO_3166_2_IQ();
            ISO_3166_2_IE();
            ISO_3166_2_IM();
            ISO_3166_2_IL();
            ISO_3166_2_IT();
            ISO_3166_2_JM();
            ISO_3166_2_JP();
            ISO_3166_2_JE();
            ISO_3166_2_JO();
            ISO_3166_2_KZ();
            ISO_3166_2_KE();
            ISO_3166_2_KI();
            ISO_3166_2_KP();
            ISO_3166_2_KR();
            ISO_3166_2_KW();
            ISO_3166_2_KG();
            ISO_3166_2_LA();
            ISO_3166_2_LV();
            ISO_3166_2_LB();
            ISO_3166_2_LS();
            ISO_3166_2_LR();
            ISO_3166_2_LY();
            ISO_3166_2_LI();
            ISO_3166_2_LT();
            ISO_3166_2_LU();
            ISO_3166_2_MO();
            ISO_3166_2_MK();
            ISO_3166_2_MG();
            ISO_3166_2_MW();
            ISO_3166_2_MY();
            ISO_3166_2_MV();
            ISO_3166_2_ML();
            ISO_3166_2_MT();
            ISO_3166_2_MH();
            ISO_3166_2_MQ();
            ISO_3166_2_MR();
            ISO_3166_2_MU();
            ISO_3166_2_YT();
            ISO_3166_2_MX();
            ISO_3166_2_FM();
            ISO_3166_2_MD();
            ISO_3166_2_MC();
            ISO_3166_2_MN();
            ISO_3166_2_ME();
            ISO_3166_2_MS();
            ISO_3166_2_MA();
            ISO_3166_2_MZ();
            ISO_3166_2_MM();
            ISO_3166_2_NA();
            ISO_3166_2_NR();
            ISO_3166_2_NP();
            ISO_3166_2_NL();
            ISO_3166_2_NC();
            ISO_3166_2_NZ();
            ISO_3166_2_NI();
            ISO_3166_2_NE();
            ISO_3166_2_NG();
            ISO_3166_2_NU();
            ISO_3166_2_NF();
            ISO_3166_2_MP();
            ISO_3166_2_NO();
            ISO_3166_2_OM();
            ISO_3166_2_PK();
            ISO_3166_2_PW();
            ISO_3166_2_PS();
            ISO_3166_2_PA();
            ISO_3166_2_PG();
            ISO_3166_2_PY();
            ISO_3166_2_PE();
            ISO_3166_2_PH();
            ISO_3166_2_PN();
            ISO_3166_2_PL();
            ISO_3166_2_PT();
            ISO_3166_2_PR();
            ISO_3166_2_QA();
            ISO_3166_2_RE();
            ISO_3166_2_RO();
            ISO_3166_2_RU();
            ISO_3166_2_RW();
            ISO_3166_2_BL();
            ISO_3166_2_SH();
            ISO_3166_2_KN();
            ISO_3166_2_LC();
            ISO_3166_2_MF();
            ISO_3166_2_PM();
            ISO_3166_2_VC();
            ISO_3166_2_WS();
            ISO_3166_2_SM();
            ISO_3166_2_ST();
            ISO_3166_2_SA();
            ISO_3166_2_SN();
            ISO_3166_2_RS();
            ISO_3166_2_SC();
            ISO_3166_2_SL();
            ISO_3166_2_SG();
            ISO_3166_2_SX();
            ISO_3166_2_SK();
            ISO_3166_2_SI();
            ISO_3166_2_SB();
            ISO_3166_2_SO();
            ISO_3166_2_ZA();
            ISO_3166_2_GS();
            ISO_3166_2_SS();
            ISO_3166_2_ES();
            ISO_3166_2_LK();
            ISO_3166_2_SD();
            ISO_3166_2_SR();
            ISO_3166_2_SJ();
            ISO_3166_2_SZ();
            ISO_3166_2_SE();
            ISO_3166_2_CH();
            ISO_3166_2_SY();
            ISO_3166_2_TW();
            ISO_3166_2_TJ();
            ISO_3166_2_TZ();
            ISO_3166_2_TH();
            ISO_3166_2_TL();
            ISO_3166_2_TG();
            ISO_3166_2_TK();
            ISO_3166_2_TO();
            ISO_3166_2_TT();
            ISO_3166_2_TN();
            ISO_3166_2_TR();
            ISO_3166_2_TM();
            ISO_3166_2_TC();
            ISO_3166_2_TV();
            ISO_3166_2_UG();
            ISO_3166_2_UA();
            ISO_3166_2_AE();
            ISO_3166_2_GB();
            ISO_3166_2_US();
            ISO_3166_2_UM();
            ISO_3166_2_UY();
            ISO_3166_2_UZ();
            ISO_3166_2_VU();
            ISO_3166_2_VE();
            ISO_3166_2_VN();
            ISO_3166_2_VG();
            ISO_3166_2_VI();
            ISO_3166_2_WF();
            ISO_3166_2_EH();
            ISO_3166_2_YE();
            ISO_3166_2_ZM();
            ISO_3166_2_ZW();

            _subdivisions = _allSubdivisions.Select(rr => new Subdivision(rr.Key)).ToList();
        }

        public Subdivision(string code) : this(GetId(code)) { }

        public Subdivision(int subdivisionId)
        {
            if (_allSubdivisions.ContainsKey(subdivisionId) == false) throw new ArgumentException("The value isn't a valid subdivision code.", nameof(subdivisionId));

            _subdivisionId = subdivisionId;
        }

        public string Code => GetEntry(_subdivisionId).Code;

        public string Name => GetEntry(_subdivisionId).Name;

        private static SubdivisionTableEntry GetEntry(int subdivisionId)
        {
            if (_allSubdivisions.TryGetValue(subdivisionId, out SubdivisionTableEntry entry) == false)
                entry = SubdivisionTableEntry.Default;

            return entry;
        }

        private static int GetId(string code) => HashCodeUtility.GetPersistentHashCode(code);

        internal static void Add(Country country, string secondPart, string name)
        {
            var entry = new SubdivisionTableEntry(country.TwoLetterCode, secondPart, name);

            _allSubdivisions.Add(entry.Id, entry);

            AddSubdivisionPerCountry(country, new Subdivision(entry.Id));
        }

        private static void AddSubdivisionPerCountry(Country country, Subdivision subdivision)
        {
            if (_subdivisionsPerCountry.ContainsKey(country) == false)
                _subdivisionsPerCountry.Add(country, new List<Subdivision>());

            _subdivisionsPerCountry[country].Add(subdivision);
        }

        private static readonly List<Subdivision> NoSubdivisions = new List<Subdivision>();

        internal static ICollection<Subdivision> GetCountrySubdivisions(Country country)
        {
            if (_subdivisionsPerCountry.ContainsKey(country) == false)
                return NoSubdivisions;

            return _subdivisionsPerCountry[country];
        }

        public static implicit operator Subdivision(string value)
        {
            return new Subdivision(value);
        }

        public static bool operator ==(Subdivision left, Subdivision right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Subdivision left, Subdivision right)
        {
            return left.Equals(right) == false;
        }

        public override bool Equals(object obj)
        {
            if (obj is Subdivision subdivision)
                return Equals(subdivision);

            return false;
        }

        public bool Equals(Subdivision other)
        {
            return _subdivisionId == other._subdivisionId;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return _subdivisionId ^ 7897;
            }
        }

        public override string ToString() => Code;

        private readonly struct SubdivisionTableEntry
        {
            const string SubdivisionPattern = @"^[a-zA-Z0-9]{0,3}$";
            static Regex Validator = new Regex(SubdivisionPattern);

            /// <summary>
            /// The internal ID of the subdivision.
            /// </summary>
            internal readonly int Id = 0;

            /// <summary>
            /// The subdivision name.
            /// </summary>
            internal readonly string Name = string.Empty;

            /// <summary>
            /// The subdivision code as described in ISO 3166-2
            /// </summary>
            internal readonly string Code = string.Empty;

            internal SubdivisionTableEntry(string countryCode, string subdivisionPart, string name)
            {
                var matchResult = Validator.Match(subdivisionPart);
                if (matchResult.Success == false)
                    throw new ArgumentException($"Invalid subdivision part. {subdivisionPart}", nameof(subdivisionPart));

                Code = $"{countryCode}-{subdivisionPart}";
                Id = HashCodeUtility.GetPersistentHashCode(Code);
                Name = name;
            }

            private SubdivisionTableEntry(int id)
            {
                Id = id;
                Code = string.Empty;
                Name = string.Empty;
            }

            public static SubdivisionTableEntry Default = new SubdivisionTableEntry(0);
        }
    }
}
