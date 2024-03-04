using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterFrameWorkRPG.Abilities
{
    public class AbilityBuilder<T> where T : AbilitiesBase, new()
    {
        public T _abilityStats = new T();

        public AbilityBuilder<T> WithName(string name)
        {
            _abilityStats.AbilityName = name;
            return this;
        }

        public AbilityBuilder<T> WithDescription(string description)
        {
            _abilityStats.AbilityDescription = description;
            return this;
        }

        

        public AbilityBuilder<T> WithAbilityModifier(double modifier)
        {
            _abilityStats.AbilityModifier = modifier;
            return this;
        }

       

        public AbilityBuilder<T> WithDamage(int damage)
        {
            _abilityStats.AbilityDamage = damage;
            return this;
        }

        public AbilityBuilder<T> WithManaCost(int manaCost)
        {
            _abilityStats.AbilityManaCost = manaCost;
            return this;
        }

        public AbilityBuilder<T> WithCoolDown(int coolDown)
        {
            _abilityStats.AbilityCoolDown = coolDown;
            return this;
        }

        public AbilityBuilder<T> WithAccuracy(int accuracy)
        {
            _abilityStats.AbilityAccuracy = accuracy;
            return this;
        }

        public AbilityBuilder<T> WithRange(int range)
        {
            _abilityStats.AbilityRange = range;
            return this;
        }

        public AbilityBuilder<T> WithDuration(int duration)
        {
            _abilityStats.AbilityDuration = duration;
            return this;
        }

        public AbilityBuilder<T> WithPassive(bool isPassive)
        {
            _abilityStats.IsPassive = isPassive;
            return this;
        }

        public AbilityBuilder<T> IsRangedEnemy(bool isRanged)
        {
            _abilityStats.IsRangedEnemy = isRanged;
            return this;
        }

        public AbilityBuilder<T> IsMeleeEnemy(bool isMelee)
        {
            _abilityStats.IsMelee = isMelee;
            return this;
        }

        public AbilityBuilder<T> IsMagicEnemy(bool isMagic)
        {
            _abilityStats.IsMagicEnemy = isMagic;
            return this;
        }

        public AbilityBuilder<T> IsHealingEnemy(bool isHeal)
        {
            _abilityStats.IsHealer = isHeal;
            return this;
        }

        public AbilityBuilder<T> CanStun(bool canStun)
        {
            _abilityStats.CanStun = canStun;
            return this;
        }

        public AbilityBuilder<T> CanSilence(bool canSilence)
        {
            _abilityStats.CanSilence = canSilence;
            return this;
        }

        public AbilityBuilder<T> CanKnockback(bool canKnockback)
        {
            _abilityStats.CanKnockback = canKnockback;
            return this;
        }
        

        public AbilityBuilder<T> WithCustomValues(Action<T> customValues)
        {
            customValues?.Invoke(_abilityStats);
            return this;
        }
       
        

    public T Build()
        {
            return _abilityStats;
        }




    }
}
