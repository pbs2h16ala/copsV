using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GTA;
using GTA.Native;
using GTA.Math;

namespace copsV.Content.Gangs
{
    abstract class Gang
    {
        public enum Faction { Biker, Freaks, Homeless, Italos, Kosaks }
        public enum Rank : int { HoodRat = 1, Thug = 2, Runner = 3, Defender = 4, Recruiter = 6, Warlord = 7, Leader = 8 }

        private Faction gangId;
        private Vector3[] homeLocations;

        private Ped[] memberTemplates;
        private Vehicle[] vehicleTemplates;
        private Weapon[] weaponTemplates;

        private Relationship[] relationToFactions;
        private Relationship relationToCops;
        private Relationship relationToWorld;
        private Relationship relationToPlayer;
        private Rank playerRankInGang;

        private int memberCount;
        private int maxMemberCount;
        private bool playerIsMember;

        private int stat_influenceToTerritory;
        private int stat_influenceToWorld;

        internal Faction GangId { get => gangId; set => gangId = value; }
        public Vector3[] HomeLocations { get => homeLocations; set => homeLocations = value; }
        public Ped[] MemberTemplates { get => memberTemplates; set => memberTemplates = value; }
        public Vehicle[] VehicleTemplates { get => vehicleTemplates; set => vehicleTemplates = value; }
        public Weapon[] WeaponTemplates { get => weaponTemplates; set => weaponTemplates = value; }
        public Relationship[] RelationToFactions { get => relationToFactions; set => relationToFactions = value; }
        public Relationship RelationToCops { get => relationToCops; set => relationToCops = value; }
        public Relationship RelationToWorld { get => relationToWorld; set => relationToWorld = value; }
        public Relationship RelationToPlayer { get => relationToPlayer; set => relationToPlayer = value; }
        internal Rank PlayerRankInGang { get => playerRankInGang; set => playerRankInGang = value; }
        public int MemberCount { get => memberCount; set => memberCount = value; }
        public int MaxMemberCount { get => maxMemberCount; set => maxMemberCount = value; }
        public bool PlayerIsMember { get => playerIsMember; set => playerIsMember = value; }
        public int Stat_influenceToTerritory { get => stat_influenceToTerritory; set => stat_influenceToTerritory = value; }
        public int Stat_influenceToWorld { get => stat_influenceToWorld; set => stat_influenceToWorld = value; }

        public abstract void Setup();
        public abstract void InitTemplates();
        public abstract void InitRelationships();

    }
}
