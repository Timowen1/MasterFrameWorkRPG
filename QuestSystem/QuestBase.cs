using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MasterFrameWorkRPG.QuestSystem
{
    public abstract class QuestBase 
    {
        
        public string Q_Name { get; set; }
        public string Q_Description { get; set; }
        public int Q_Id { get; set; }
        public bool Q_Status { get; set; }
        public int Q_LevelRequirement { get; set; }
        public int RewardExp { get; set; }
        public int RewardCurrency { get; set; }
        public GameObject RewardItem { get; set; }
        public int Q_Location { get; set; }
        public float GlobalTimer { get; set; }
        public int QuestTracker { get; set; }
        public int Q_RegionId { get; set; }

        protected QuestRewards Rewards;
        public abstract string GenerateQuestName();
        public abstract string GenerateQuestDescription();

        public QuestBase(string name, string description, int id, bool status, int requirement, int exp, int currency, GameObject rewardItem, int tracker)
        {
            Q_Name = name;
            Q_Description = description;
            Q_Id = id;
            Q_Status = status;
            Q_LevelRequirement = requirement;
            QuestTracker = tracker;
            Rewards = new QuestRewards();
            SetRewards(exp, currency, rewardItem);
        }

        private void SetRewards(int exp, int currency, GameObject rewardItem)
        {
            RewardExp = exp;
            RewardCurrency = currency;
            RewardItem = rewardItem;
        }
        /// <summary>
        /// This method checks to see if a quest is active, if not it will assign a quest based off what is in the GenerateNewQuest() 
        /// </summary>
        public void AssignNewQuest()
        {
            if (!Q_Status)
            {
                if(IsQuestActive())
                {
                    Debug.Log("Quest is active"); //send a log that checks if the quest is active
                }

                GenerateNewQuest();
                Q_Status = true;
            }

        }

        public virtual void GenerateNewQuest()
        {
            Q_Name = GenerateQuestName();
            Q_Description = GenerateQuestDescription();

            Rewards.Reset();
            
        }

        public int GetRewardExp()
        {
            return RewardExp;
        }

        public int GetRewardCurrency()
        {
            return RewardCurrency;
        }
        public GameObject GetRewardItem()
        {
            return RewardItem;
        }

        public bool IsQuestActive()
        {
            return Q_Status;
        }
    }
}
