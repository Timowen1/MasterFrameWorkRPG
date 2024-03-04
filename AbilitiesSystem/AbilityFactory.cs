using MasterFrameWorkRPG.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace MasterFrameWorkRPG.Abilities
{
    public class AbilityFactory
    {
        public int Value { get; set; }
        public string Text { get; set; }    
        public AbilitiesBase CreateAbility(AbilitiesBase.AbiltyType type)
        {
            return new AbilityBuilder<AbilitiesBase>()
                 .WithAccuracy(Value)
                 .WithCoolDown(Value)
                 .WithDescription(string.IsNullOrEmpty(Text) ? "Enter descriptionof ability here" : Text)
                 .WithPassive(false)
                 .WithRange(Value)
                 .CanStun(false)
                 .CanSilence(false)
                 .CanKnockback(false)
                 .IsHealingEnemy(false)
                 .WithDamage(Value)
                 .WithManaCost(Value)
                 .WithRange(Value)
                 .WithDuration(Value)
                 .Build();
                
        }

        public AbilitiesBase Fire (AbilitiesBase.AbiltyType type)
        {

            return new AbilityBuilder<AbilitiesBase>()
                .WithName("Fire")
                .WithDescription("This casts a wave of fire")
               // .WithDamage()
                .Build();
                
                }
        

    }

}





