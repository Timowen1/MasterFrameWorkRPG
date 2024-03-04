using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MasterFrameWorkRPG.QuestSystem
{
   public class FetchItemQuest : QuestBase
    {
        public string ItemToFetch { get; set; }
        public int RequiredAmount { get; set; }

        public FetchItemQuest(string name, string description, int id, bool status, int requirement, int exp, int currency, GameObject rewardItem, int location, string itemToFetch, int requiredAmount)
            : base(name, description, id, status, requirement, exp, currency, rewardItem, location)
        {
            ItemToFetch = itemToFetch;
            RequiredAmount = requiredAmount;
        }

        public override string GenerateQuestDescription()
        {
            return $"Travel to a specified location and collect {RequiredAmount} {ItemToFetch}(s).";
        }
        public override string GenerateQuestName()
        {
            return $"";
        }
    }
}
