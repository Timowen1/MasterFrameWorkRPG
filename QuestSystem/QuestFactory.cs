using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using MasterFrameWorkRPG.NPCSystem;

namespace MasterFrameWorkRPG.QuestSystem
{
    public class QuestFactory : QuestBase
    {

        List<Items> playerInventory;

        public QuestFactory(string name, string description, int id, bool status, int requirement, int exp, int currency, GameObject rewardItem, int tracker)
            : base(name, description, id, status, requirement, exp, currency, rewardItem, tracker)
        {
            playerInventory = new List<Items>();
        }

        public override void GenerateNewQuest()
        {
            // The base class implementation of generating a new quest can be kept as is
            base.GenerateNewQuest();
        }

        public FetchItemQuest CreateFetchItemQuest(string questName, string questDescription, string itemToFetch, int requiredAmount, int targetLocation)
        {
            // Generate a new FetchItemQuest with specific parameters
            return new FetchItemQuest(questName, questDescription, GenerateQuestId(), false, GenerateRequiredLevel(), RewardExp, RewardCurrency, RewardItem, targetLocation, itemToFetch, requiredAmount);
        }

        public DefeatEnemyQuest CreateDefeatEnemyQuest(string questName, string questDescription,string enemyToDefeat, int requiredEnemyCount, int targetLocation)
        {
            // Generate a new DefeatEnemyQuest with specific parameters
            return new DefeatEnemyQuest(questName,questDescription, GenerateQuestId(), false, GenerateRequiredLevel(), RewardExp, RewardCurrency, RewardItem, targetLocation, enemyToDefeat);
        }

        private int GenerateQuestId()
        {
            // Implement logic to generate a unique quest ID (e.g., increment a counter)
            return 1000;  // Placeholder value, replace with actual logic
        }

        private int GenerateRequiredLevel()
        {
            // Implement logic to generate a required level for the quest
            return 5;  // Placeholder value, replace with actual logic
        }

        public override string GenerateQuestDescription()
        {
            return "Enter quest name here";
        }

        public override string GenerateQuestName()
        {
            return "Enter Quest description here";
        }
        
        public void CollectItem (Items item)
        {
            playerInventory.Add(item);
        }

        public int CountCollectedItems(string itemName)
        {
            int count = 0; 
            foreach (Items item in playerInventory)
            {
                if (item.Name == itemName)
                {
                    count += item.Value;
                }
            }
            return count;
        }

    }

}

