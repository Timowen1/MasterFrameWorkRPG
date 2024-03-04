using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterFrameWorkRPG.NPCSystem;

namespace MasterFrameWorkRPG.QuestSystem
{
    public class QuestProgression
    {
        QuestFactory questFactory;

        private List<QuestBase> activeQuests;

        public QuestProgression()
        {
            activeQuests = new List<QuestBase>();
        }

        public void AddActiveQuest(QuestBase quest)
        {
            if (!activeQuests.Contains(quest))
            {
                activeQuests.Add(quest);
            }
        }

        public void RemoveCompletedQuests()
        {
            activeQuests.RemoveAll(quest => quest.Q_Status);
        }

        public void UpdateQuestProgress()
        {
            foreach (QuestBase quest in activeQuests)
            {
                if (quest is FetchItemQuest fetchQuest)
                {
                    // Check if the required item has been collected by the player.
                    int collectedAmount = questFactory.CountCollectedItems(fetchQuest.ItemToFetch);

                    // Update quest progress based on collected items.
                    if (collectedAmount >= fetchQuest.RequiredAmount)
                    {
                        // Mark the quest as completed.
                        quest.Q_Status = true;
                    }
                }
            }

        }
        
    }
}
        
    
