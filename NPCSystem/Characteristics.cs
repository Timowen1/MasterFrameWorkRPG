using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterFrameWorkRPG.NPCSystem

{
    public abstract class Characteristics
    {
        //Nature of creature/NPC's

        public enum CharacterNature
        { 
            Aggressive,
            Passive,
            Neutral
        }

        public CharacterNature typeOfNature { get; set; }

        //Levels and multipliers for the level of nature
        public int Threshold { get; set; }
        public int AggroLevel { get; set; }
        public int PlayerIncitedAgression { get; set; }


        //Flags to check status    
        public bool IsAggressive { get { return typeOfNature == CharacterNature.Aggressive; } }
        public bool IsPassive { get { return typeOfNature == CharacterNature.Passive; } }
        public bool IsNeutral { get { return typeOfNature == CharacterNature.Neutral; } }


        public Characteristics(CharacterNature charNature, int thresh)
        {
            Threshold = thresh;
            typeOfNature = charNature;
            AggroLevel = 0;
            PlayerIncitedAgression = 0;
           
        }



            


    }
}
