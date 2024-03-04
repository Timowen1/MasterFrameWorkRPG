using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterFrameWorkRPG.QuestSystem
{
   public class RewardItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public RewardItem(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }
    }
}
