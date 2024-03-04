using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterFrameWorkRPG.AIFrameWork
{
    public class GOAP_Goals
    {

        public string GoalName { get; }
        public Dictionary<string, bool> GoalState { get; }

        public GOAP_Goals(string name)
        {
            GoalName = name;
            GoalState = new Dictionary<string, bool>();
        }

        public bool IsGoalAchieved(Dictionary<string, bool> worldState)
        {
            // Check if all goal conditions are met in the current world state
            foreach (var condition in GoalState)
            {
                if (!worldState.ContainsKey(condition.Key) || worldState[condition.Key] != condition.Value)
                {
                    return false;
                }
            }
            return true;
        }
    }





}

