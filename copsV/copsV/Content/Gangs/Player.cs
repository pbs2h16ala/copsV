using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GTA;
using GTA.Native;
using GTA.Math;
using static copsV.Content.Gangs.Gang;

namespace copsV.Content.Gangs
{
    class Player
    {
        private Relationship[] relationToGangs;
        private Rank[] rankInGangs;

        public Relationship[] RelationToGangs { get => relationToGangs; set => relationToGangs = value; }
        internal Rank[] RankInGangs { get => rankInGangs; set => rankInGangs = value; }
    }
}
