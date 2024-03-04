using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterFrameWorkRPG.AIFrameWork
{
    public class PatrolAction : GOAP_Action
    {
        public PatrolAction() :base ("Patrol")
        {
            Preconditions.Add("IsIdle", true);
            Effects.Add("IsIdle", false);
            Effects.Add("IsPatrolling", true);
        }

        public override bool Execute()
        {
            return base.Execute();
        }

    }
}
