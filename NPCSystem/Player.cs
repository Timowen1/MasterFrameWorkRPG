using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MasterFrameWorkRPG.NPCSystem
{
    public class Player
    {
        public int Health { get; set; }
        public bool IsDead { get; protected set; }


        public List<Items> Inventory { get; set; }
        public int GetPlayerCurrentLevel { get; set; }
        public void TakeDamage(int damage, Enemies.AttackType attackType)
        {
            Health -= damage;

            if(Health >=0)
            {
                Health = 0;
                IsDead = true;
                Die();
            }
        
        }
       

        public void Die()
        {
            //gameover
        }
        public void CollectItem(Items item)
        {
            Inventory.Add(item);
        }

        public void RespawnPlayer()
        {
            //Reload character wherever I choose lol havent gotten that far yet
        }



    }
}
