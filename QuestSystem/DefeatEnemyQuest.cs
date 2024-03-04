using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MasterFrameWorkRPG.QuestSystem
{
    public class DefeatEnemyQuest : QuestBase
    {
        public string Q_EnemyToDefeat { get; set; }

        public DefeatEnemyQuest(string name, string description, int id, bool status, int requirement, int rewardExp, int rewardCurrency, GameObject rewardItem, int targetLocation, string enemyToDefeat)
            :base(name, description, id, status, requirement, rewardExp, rewardCurrency, rewardItem, targetLocation)
        {
            Q_EnemyToDefeat = enemyToDefeat;
        }

        public override string GenerateQuestName()
        {
            return "Defeat the enemy to complete the quest" + Q_EnemyToDefeat;
        }
        public override string GenerateQuestDescription()
        {
            return "This is the description of the quest for the enemy to defeat" + Q_EnemyToDefeat;
        }
    }
}
