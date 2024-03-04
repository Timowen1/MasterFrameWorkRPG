using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterFrameWorkRPG.DialogeFramework
{
   public class CustomDialogueManager :DialogueManagerBase
    {
        // Override the display logic to suit your game's requirements
        public override void StartConversation(string speaker, string dialogue)
        {
            // Implement your custom display logic here
            base.StartConversation(speaker, dialogue);
        }

        public override void ContinueConversation()
        {
            // Implement your custom logic to proceed to the next dialogue
            base.ContinueConversation();
        }

    }
}
