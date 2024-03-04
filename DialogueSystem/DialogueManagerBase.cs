using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterFrameWorkRPG.DialogeFramework
{
    public abstract class DialogueManagerBase
    {

        // Properties to store dialogue information
        protected string currentSpeaker;
        protected string currentDialogue;

        // Method to start a new conversation
        public virtual void StartConversation(string speaker, string dialogue)
        {
            currentSpeaker = speaker;
            currentDialogue = dialogue;
            // Implement logic to display the dialogue on the screen or in a UI panel
        }

        // Method to proceed to the next dialogue
        public virtual void ContinueConversation()
        {
            // Implement logic to move to the next dialogue line or end the conversation
        }
    }

}

