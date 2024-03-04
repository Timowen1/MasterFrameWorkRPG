using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterFrameWorkRPG.AIFrameWork
{
    public class WanderAction : GOAP_Action
    {
        public WanderAction() :base("Wander")
        {
            Preconditions.Add("IsIdle", true);
            Effects.Add("IsIdle", false);
            Effects.Add("IsWandering", true);
        }

        public override bool Execute()
        {
            //Add wander logic

            return base.Execute();
        }
    }
}
