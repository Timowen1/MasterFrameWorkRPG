using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MasterFrameWorkRPG.NPCSystem
{
    public abstract class Enemies 
    {
        public int enemyLvl;

        public EnemyType typeOfEnemy;
        public int Health { get; internal set; }
        public int MaxHealth { get; set; }
        public int AttackMelee { get; internal set; }
        public int AttackMagic { get; internal set; }
        public int Defense { get; internal set; }
        public int MagicDefense { get; internal set; }
        public int SpecialAttack { get; internal set; }
        public int Magic { get; internal set; }
        public int Speed { get; internal set; }
        public string Name { get; internal set; }
        public int SpeedBase { get; internal set; }
        public int Luck { get; internal set; }
        public int Accuracy { get; internal set; } 
        //public string Description { get; protected set; }
        public bool HasSpecialAttack { get; set; }

        public bool isDead = false;
        public bool isMelee = false;
        public bool isMagic = false;
        
        public List<Items> DroppedItems { get; internal set; }


        public enum EnemyType
        {
            Monster,
            Human,
            NPC
        }

        public enum AttackType
        {
            Melee,
            Magic,
            Special
        }

        protected Enemies(int enemyLvl, EnemyType type, int health, int accuracy, int attackMelee, int magicAttack, int specialAttack, int defense, int magicDefense, int luck, int speed, string name)
        {
            this.enemyLvl = enemyLvl;
            this.typeOfEnemy = type;
            Health = health;
            AttackMelee = attackMelee;
            AttackMagic = magicAttack;
            Defense = defense;
            MagicDefense = magicDefense;
            SpecialAttack = specialAttack;
            Speed = speed;
            Name = name;
            Luck = luck;
            Accuracy = accuracy;

            DroppedItems = new List<Items>();
            
        }

        
        /*
        public Enemies(int enemyLvl, EnemyType type, int health, int accuracy, int attackMelee, int specialAttack, int defense, int speed, string name)
        {
            this.enemyLvl = enemyLvl;
            this.typeOfEnemy = type;
            Health = health;
            AttackMelee = attackMelee;
            Defense = defense;
            SpecialAttack = specialAttack;
            Speed = speed;
            Name = name;
            Accuracy = accuracy;
            DroppedItems = new List<Items>();
            
        }
        */

        
        public virtual void Attack(Player target, AttackType attackType)
        {
            int damage = CalculateDamage(attackType);

            bool AttackHasHit = new Random().NextDouble() < Accuracy / 100.0;

            if (AttackHasHit)
            {
                target.TakeDamage(damage, attackType);

            }

            target.TakeDamage(damage, attackType);

        }

        public virtual void TakeDamage(int damage, AttackType attackType)
        {
            Health -= damage;

            if(Health < 0)
            {
                Health = 0;
                Die();
            }

            /*
            switch(attackType)
            {
                
                case AttackType.Melee:
                    damage = CalculateDamage(AttackType.Melee);
                    break;
                case AttackType.Magic:
                    damage = CalculateDamage(AttackType.Magic);
                    break;
                case AttackType.Special:
                    damage = CalculateDamage(AttackType.Special);
                    break;
                default: damage = 0;
                    break;
            }
            */
        }

        public virtual int BaseDefense(int incomingDamage, AttackType attackType)
        {
            int defenseValue = GetDefenseValue(attackType);

            if (attackType == AttackType.Melee)
            {
                defenseValue = Defense;
            }

            else if (attackType == AttackType.Magic)
            {
                defenseValue = MagicDefense;
            }

            int reduceDamage = incomingDamage - defenseValue;

            reduceDamage = Math.Max(reduceDamage, 0);

            Health -= reduceDamage;

            if (Health <= 0)
            {
                Die();
            }

            return reduceDamage;
        }

        protected int GetDefenseValue(AttackType attackType)
        {
            int baseDefense = 10;

            if (attackType == AttackType.Melee)
            {
                return Defense > 0 ? Defense : baseDefense;
            }

            if(attackType == AttackType.Magic)
            {
                return MagicDefense > 0 ? MagicDefense : baseDefense;
            }

            return baseDefense;
        }

        protected int CalculateDamage(AttackType attackType)
        {
            int damage = 0;

            if(attackType == AttackType.Magic)
            {
                damage = AttackMagic;
            }

            else if (attackType == AttackType.Melee)
            {
                damage = AttackMelee;
            }
            else if (attackType == AttackType.Special)
            {
                damage = SpecialAttack; 
            }

            return damage;
        }

        public virtual void Die()
        {
           if(Health == 0)
            {
                isDead = true;
            }
        }


        //Create a method to assgin ExpValue to each monster based on their level ranging from level 1-100
        public virtual int GetExpValue()
        {
            int expValue = 0;

            if(enemyLvl >= 1 && enemyLvl <= 10)
            {
                expValue = 10;
            }
            else if(enemyLvl >= 11 && enemyLvl <= 20)
            {
                expValue = 20;
            }
            else if(enemyLvl >= 21 && enemyLvl <= 30)
            {
                expValue = 30;
            }
            else if(enemyLvl >= 31 && enemyLvl <= 40)
            {
                expValue = 40;
            }
            else if(enemyLvl >= 41 && enemyLvl <= 50)
            {
                expValue = 50;
            }
            else if(enemyLvl >= 51 && enemyLvl <= 60)
            {
                expValue = 60;
            }
            else if(enemyLvl >= 61 && enemyLvl <= 70)
            {
                expValue = 70;
            }
            else if(enemyLvl >= 71 && enemyLvl <= 80)
            {
                expValue = 80;
            }
            else if(enemyLvl >= 81 && enemyLvl <= 90)
            {
                expValue = 90;
            }
            else if(enemyLvl >= 91 && enemyLvl <= 100)
            {
                expValue = 100;
            }

            return expValue;
        }


        // You can add more properties and methods as needed.
    }
}

