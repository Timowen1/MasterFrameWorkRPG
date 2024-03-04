using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterFrameWorkRPG.NPCSystem
{
    public abstract class MonsterBuilder <T> where T : Enemies, new()
    {
        private T _monsterStats = new T();


        public MonsterBuilder<T> WithLevel(int level)
        {
            _monsterStats.enemyLvl = level;
            return this;
        }

        public MonsterBuilder<T>WithType(Enemies.EnemyType type)
        {
            _monsterStats.typeOfEnemy = type;
            return this;
        }   

        public MonsterBuilder<T> WithHealth(int health)
        {
            _monsterStats.Health = health; 
            return this;
        }
        public MonsterBuilder<T> WithAttackMelee(int attackMelee)
        {
            _monsterStats.AttackMelee = attackMelee; 
            return this;
        }
        public MonsterBuilder<T> WithAttackMagic(int attackMagic)
        {
            _monsterStats.AttackMagic = attackMagic; 
            return this;
        }
        public MonsterBuilder<T> WithDefense(int defense)
        {
            _monsterStats.Defense = defense; 
            return this;
        }
        public MonsterBuilder<T> WithMagicDefense(int magicDefense)
        {
            _monsterStats.MagicDefense = magicDefense;
            return this;
        }
        public MonsterBuilder<T> WithSpecialAttack(int specialAttack)
        {
            _monsterStats.SpecialAttack = specialAttack; 
            return this;
        }
        public MonsterBuilder<T> WithSpeed(int speed)
        {
            _monsterStats.SpeedBase = speed; 
            return this;
        }
        public MonsterBuilder<T> WithName(string name)
        {
            _monsterStats.Name = name; 
            return this;
        }
        public MonsterBuilder<T> WithLuck(int luck)
        {
            _monsterStats.Luck = luck; 
            return this;
        }
        public MonsterBuilder<T> WithAccuracy(int accuracy)
        {
            _monsterStats.Accuracy = accuracy; 
            return this;
        }

        public T Build()
        {
            return _monsterStats;
        }


        
    }



}
