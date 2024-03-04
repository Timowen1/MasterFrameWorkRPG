using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterFrameWorkRPG.Abilities
{
    public class AbilitiesBase
    {
        #region Properties
        public string AbilityName { get; internal set; }
        public string AbilityDescription { get; internal set; }
       
        
        public double AbilityModifier { get; internal set; }
        public AbiltyType Type { get; set; }
        
        public int AbilityDamage { get; internal set; }
        public int AbilityManaCost { get; internal set; }
        public int AbilityCoolDown { get; internal set; }
        public int AbilityAccuracy { get; internal set; }
        public int AbilityRange { get; internal set; }
        public int AbilityDuration { get; internal set; }
        public bool IsPassive { get; internal set; }
        public bool IsRangedEnemy { get; internal set; }
        public bool IsMelee { get; internal set; }
        public bool IsMagicEnemy { get; internal set; }
        public bool IsHealer { get; internal set; }
        public bool CanStun { get; internal set; }
        public bool CanSilence { get; internal set; }
        public bool CanKnockback { get; internal set; }  
        

        #endregion

        public AbilitiesBase()
        {
            
        }

        public enum AbiltyType
        {
            Heal,
            Stun,
            Silence,
            Buff,
            Debuff,
            Knockback,
            Fire,
            Water,
            Earth,
            Wind,
            Ice,
            Poison,
            Summons,

        }

        

    }
}
