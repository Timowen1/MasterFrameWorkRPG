using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterFrameWorkRPG.AIFrameWork
{
    public class AttackAction :GOAP_Action
    {
        public AttackAction() :base("Attack")
        {
            Preconditions.Add("IsIdle", true);
            Effects.Add("IsIdle", false);
            Effects.Add("IsAttacking", true);
        }

        public override bool Execute()
        {
            return base.Execute();
        }


    }
}
