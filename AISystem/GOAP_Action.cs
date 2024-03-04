using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterFrameWorkRPG.AIFrameWork
{
    public class GOAP_Action
    {
        public string ActionName { get; }
        public Dictionary<string, bool> Preconditions { get; }
        public Dictionary<string, bool> Effects { get; }

        public GOAP_Action(string name)
        {
            ActionName = name;
            Preconditions = new Dictionary<string, bool>();
            Effects = new Dictionary<string, bool>();
        }

        public bool IsActionValid(Dictionary<string, bool> worldState)
        {
            // Check if all preconditions are met in the current world state
            foreach (var precondition in Preconditions)
            {
                if (!worldState.ContainsKey(precondition.Key) || worldState[precondition.Key] != precondition.Value)
                {
                    return false;
                }
            }
            return true;
        }

        public virtual bool Execute()
        {
            return true;
        }




    }
}

