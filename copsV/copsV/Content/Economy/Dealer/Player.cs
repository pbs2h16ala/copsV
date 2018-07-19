using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copsV.Content.Economy.Dealer
{
    class Player
    {

        public enum DealerRank:int { StreetWalker=0, Runner=1, Allocator=2, Wannabe=3, Prooved=4, Respected=5, Influencer=6, RightHand=7, Leader=8, Owner=9, Legend=10  }
        public enum CustomerReputation:int { None=0, Best=1, Great=2, Liked=3, Statisfied=4, Unlucky=5, Hatefull=6, Endangered = 7 }


        private double currentMoney;
        private int rankProgress;
        private int reputationProgress;

        private Backpack backpack;
    }
}
