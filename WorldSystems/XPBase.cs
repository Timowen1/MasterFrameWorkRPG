using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterFrameWorkRPG.WorldSystems
{
    public class XPBase
    {
        public int BaseXp { get; set; }
        public int MonsterMultiplier { get; set; }
        public int MonsterLevel { get; set; }
        public int PlayerLevel { get; set; }
        public int LevelDifferenceMultiplier { get; set; }


        public int CalculateXP()
        {
            int gainedXp;

            gainedXp = BaseXp * MonsterMultiplier * (1 + MonsterLevel) * (1 + (PlayerLevel - MonsterLevel) * LevelDifferenceMultiplier);

            return gainedXp;
        }


        /*
         * Sample of how to assign and use this
         * XPBase xpCalculator = new XPBase();
         * xpCalculator.BaseXp = 500;  // Set the base XP
         * xpCalculator.MonsterMultiplier = 2;  // Set the monster multiplier
         * xpCalculator.MonsterLevel = 2;  // Set the monster level
         * xpCalculator.PlayerLevel = 5;  // Set the player level
         * xpCalculator.LevelDifferenceMultiplier = 0.1;  // Set the level difference multiplier

         * int xpGained = xpCalculator.CalculateXP();  // Calculate XP
         * 
        */
    }
}
