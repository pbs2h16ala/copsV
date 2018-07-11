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
        public enum GangFaction { Biker, Freaks, Homeless }
        public enum Rank:int { HoodRat=1, Thug=2, Runner=3, Defender=4, Recruiter=6, Warlord=7, Leader=8 }

        private Ped[] memberTemplates;
        private Vehicle[] vehicleTemplates;
        private Weapon[] weaponTemplates;

        private Relationship[] relationToFactions;
        private Relationship relationToWorld;
        private Relationship realtionToPlayer;

        private int memberCount;
        private int maxMemberCount;
        private bool playerIsMember;

        private int stat_influenceToTerritory;
        private int stat_influenceToWorld;

        public Ped[] MemberTemplates { get => memberTemplates; set => memberTemplates = value; }
        public Vehicle[] VehicleTemplates { get => vehicleTemplates; set => vehicleTemplates = value; }
        public Weapon[] WeaponTemplates { get => weaponTemplates; set => weaponTemplates = value; }
        public Relationship[] RelationToFactions { get => relationToFactions; set => relationToFactions = value; }
        public Relationship RelationToWorld { get => relationToWorld; set => relationToWorld = value; }
        public Relationship RealtionToPlayer { get => realtionToPlayer; set => realtionToPlayer = value; }
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
