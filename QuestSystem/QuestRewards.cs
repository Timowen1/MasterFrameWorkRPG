using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MasterFrameWorkRPG.QuestSystem
{
    public class QuestRewards
    {
        
       public int AddExp { get; set; }
       public int EnemyLevel { get; set; }
       public int GainedExp { get; set; } 
        
        protected List<RewardItem> RewardItems { get; }

        public QuestRewards()
        {
            RewardItems = new List<RewardItem>();
        }

        public void AddRewardItem(RewardItem item)
        {
            RewardItems.Add(item);
        }

        public void SetExperiencePoints(int exp)
        {
            // Implement the logic to handle experience points


        }

        public void SetCurrency(int currency)
        {
            // Implement the logic to handle currency
        }

        public void Reset()
        {
            RewardItems.Clear();
        }
    }

   



}
