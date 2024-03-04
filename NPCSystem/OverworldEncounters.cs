using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


namespace MasterFrameWorkRPG.NPCSystem
{
    public class OverworldEncounters :MonoBehaviour
    {

        int numOfStepsTaken = 0;

		int currentStepCount = 0;

		Vector2 worldRegion;

		int characterDifficultlyLevel;

		int enemyLevelToSpawn;

        void Update()
        {
            UpdateStepCount();
        }


        /// <summary>
        /// This method does nothing
        /// </summary>
		void CalculateSteps()
        {
            currentStepCount = Mathf.Min(numOfStepsTaken, 20);
        }

        private void UpdateStepCount()
        {
                currentStepCount++;
        }

        
    }
}
