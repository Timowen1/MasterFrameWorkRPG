using System;
using System.Collections.Generic;
using System.Timers;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;

namespace MasterFrameWorkRPG.NPCSystem
{
    
    public class Monsters : Enemies
    {
        //public int ExpValue { get; protected set; }
        public bool isNotDead = false;
        public bool isFleeing = false;  
        public MonsterType Type { get; set; } 
        public int ExpValue { get; protected set; }
        public int StartingHealth { get; set; }
        public Timer SpecialAttackCoolDownTImer { get;  protected set; }
        public bool CanUseSpecialAttack { get; protected set; } = true; 
        private static readonly Random rand = new Random();
        public string Description { get; protected set; }
        public MonsterBehaviour Behaviour { get; set; }   

        private Monsters(int enemyLvl, int health, int accuracy, int attackMelee, int magicAttack, int specialAttack, int defense, int magicDefense, int luck, int speed, string name, MonsterType type, string description, MonsterBehaviour behaviour)
    : base(enemyLvl, EnemyType.Monster, health, accuracy, attackMelee, magicAttack, specialAttack, defense, magicDefense, luck, speed, name)
        {
            // Initialize Monster-specific properties here 
            SpecialAttackCoolDownTImer = new Timer(3000); // 3 seconds
            SpecialAttackCoolDownTImer.Elapsed += (sender, e) =>
            {
                // Special attack is ready to use again
                if (Health > 0)
                {
                    CanUseSpecialAttack = true;
                }

                // Monster is dead it stops the timer
                else
                {
                    ((Timer)sender).Stop();
                }

            };

            SpecialAttackCoolDownTImer.AutoReset = false;
            ExpValue = enemyLvl;
            DroppedItems = new List<Items>();
            HasSpecialAttack = false;
            StartingHealth = health;
            Type = type;
            Description = description;
            Behaviour = behaviour;
        }

        public enum MonsterType
        {
            Slime,
            Goblin,
            Orc,
            Troll,
            Dragon,
            Wyvern,
            Chimera,
            Behemoth,
            DemiGod,
            Wolf,
        }

        public enum MonsterBehaviour
        {
            Passive,
            Aggressive,
            Defensive,
            Neutral
        }
        
        public override int GetExpValue()
        {

            return base.GetExpValue();
        }
        public override int BaseDefense(int incomingDamage, AttackType attackType)
        {
            int defenseValue = GetDefenseValue(attackType);

            if(attackType == AttackType.Melee)
            {
                defenseValue = Defense;
            }

            else if(attackType == AttackType.Magic)
            {
                defenseValue = MagicDefense;
            }

            int reduceDamage = incomingDamage - defenseValue;

            reduceDamage = Math.Max(reduceDamage, 0);

            Health -= reduceDamage;

            if(Health <= 0)
            {
                Die();
            }

            return reduceDamage;
        }

        public override void TakeDamage(int damage, AttackType attackType)
        {
            base.TakeDamage(damage, attackType);
            int reduceDamage = BaseDefense(damage, attackType);

            Health -= reduceDamage;
            if(Health <= 0)
            {
                Die(); 
            }
        }
        
        public void Flee()
        {
            isFleeing = true;
        }


        public override void Attack(Player target, AttackType attackType)
        {
            base.Attack(target, attackType);

            int damage = CalculateDamage(attackType);

            // Calculate the chance for the monster to flee. This is based on various factors such as
            // the monster's current health and the level of the player.
            double fleeChance = CalculateFleeChance(target);

            // If a random number is less than the flee chance, the monster flees and the method returns early.
            if (rand.NextDouble() < fleeChance)
            {
                Flee();
                return;
            }

            // The monster has a 20% chance to use a special attack, if it's available.
            double specialAttackChance = 0.2;
            if (HasSpecialAttack && CanUseSpecialAttack && new Random().NextDouble() < specialAttackChance)
            {
                damage = CalculateDamage(AttackType.Special);
                target.TakeDamage(damage, attackType);
                CanUseSpecialAttack = false;
                SpecialAttackCoolDownTImer.Start();
                return;
            }

            // If the monster didn't flee or use a special attack, it performs a regular attack.
            damage = CalculateDamage(attackType);
            target.TakeDamage(damage, attackType);
        }


        public double CalculateFleeChance(Player target)
        {
            // Start with a base flee chance.
            double fleeChance = GetBaseFleeChance();

            // Calculate the monster's current health as a percentage of its starting health.
            double healthPercentage = (double)Health / StartingHealth;

            // Adjust the flee chance based on the monster's current health.
            fleeChance = AdjustFleeChanceForHealth(fleeChance, healthPercentage);

            // Further adjust the flee chance based on the level of the player compared to the monster.
            fleeChance = AdjustFleeChanceForEnemyLevel(fleeChance, target, healthPercentage);

            return fleeChance;
        }

        private double GetBaseFleeChance()
        {
            return 0.1; // Base flee chance
        }

        protected double AdjustFleeChanceForHealth(double fleeChance, double healthPercentage)
        {
            if (healthPercentage < 0.2)
            {
                fleeChance = 0.3; // Increase flee chance if health is low
            }

            return fleeChance;
        }

        protected double AdjustFleeChanceForEnemyLevel(double fleeChance, Player target, double healthPercentage)
        {
            if (enemyLvl > target.GetPlayerCurrentLevel)
            {
                fleeChance = 0.2; // Increase flee chance if enemy level is higher
            }
            else if (enemyLvl < target.GetPlayerCurrentLevel && healthPercentage > 0.5)
            {
                fleeChance = 0.01; // Decrease flee chance if enemy level is lower and health is high
            }

            return fleeChance;
        }

        public void AddDroppedItem(Items item)
        {
            DroppedItems.Add(item);
        }

        public void RemoveDroppedItem(Items item)
        {
            DroppedItems.Remove(item);
        }

        public void ClearDroppedItem(Items item)
        {
            DroppedItems.Clear();
        }

        public virtual void AssignDroppedItems()
        {
            
            DroppedItems.Clear();

            for(int i = 0; i < 6; i++)
            {
                int randomID = rand.Next(1, 7);
                if (Items.itemTable.ContainsKey(i))
                {
                    DroppedItems.Add(Items.itemTable[randomID]);
                }
            }
            
            


        }

    }
}
