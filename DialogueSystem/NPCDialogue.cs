using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;



namespace MasterFrameWorkRPG.DialogeFramework
{
    public class NPCDialogue : MonoBehaviour
    {
        /*
        // A reference to the text component that displays the dialogue
        public Text dialogueText;

        // A reference to the button component that displays the options
        public Button optionButton;

        // A variable to store the current dialogue node ID
        private int currentNodeID;

        // A variable to store the dialogue data
        private Dialogue dialogue;

        // A method to load the dialogue data from a JSON file
        private void LoadDialogue(string fileName)
        {
            // Load the JSON file as a TextAsset
            TextAsset textAsset = Resources.Load<TextAsset>(fileName);

            // Parse the JSON file into a Dialogue object
            dialogue = JsonUtility.FromJson<Dialogue>(textAsset.text);
        }

        // A method to start a conversation with the NPC
        public void StartConversation()
        {
            // Load the dialogue data from a file named "dialogue.json"
            LoadDialogue("dialogue");

            // Set the current node ID to 0, which is the start node
            currentNodeID = 0;

            // Show the dialogue panel
            dialoguePanel.SetActive(true);

            // Display the current node
            DisplayNode();
        }

        // A method to display a dialogue node based on the current node ID
        private void DisplayNode()
        {
            // Find the dialogue node that matches the current node ID
            DialogueNode node = dialogue.nodes.Find(n => n.nodeID == currentNodeID);

            // If the node is not found, end the conversation
            if (node == null)
            {
                EndConversation();
                return;
            }

            // Set the dialogue text to the node text
            dialogueText.text = node.text;

            // Clear any existing options from the previous node
            ClearOptions();

            // Loop through each option in the node
            foreach (DialogueOption option in node.options)
            {
                // Create a new button for each option
                Button button = Instantiate(optionButton);

                // Set the button text to the option text
                button.GetComponentInChildren<Text>().text = option.text;

                // Add a listener to the button click event
                button.onClick.AddListener(() => OnOptionSelected(option));

                // Make the button a child of the dialogue panel
                button.transform.SetParent(dialoguePanel.transform, false);
            }
        }

        // A method to clear any existing options from the previous node
        private void ClearOptions()
        {
            // Find all the buttons that are children of the dialogue panel
            Button[] buttons = dialoguePanel.GetComponentsInChildren<Button>();

            // Loop through each button and destroy it
            foreach (Button button in buttons)
            {
                Destroy(button.gameObject);
            }
        }

        // A method to handle an option selection by the player
        private void OnOptionSelected(DialogueOption option)
        {
            // Set the current node ID to the option destination node ID
            currentNodeID = option.destinationNodeID;

            // Display the new node
            DisplayNode();
        }

        // A method to end a conversation with the NPC
        public void EndConversation()
        {
            // Hide the dialogue panel
            dialoguePanel.SetActive(false);
        }
        */
    }
        
}
