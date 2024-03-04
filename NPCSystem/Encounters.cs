using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MasterFrameWorkRPG.NPCSystem
{
    public abstract class Encounters
    {

        protected int enemyLevel;
        protected bool isCompleted;
        public EncounterType typeOfEncounter;
        public enum EncounterType
        {
           CommonArea,
        }


        public Encounters(int enemyLevel, EncounterType typeOfEncounter)
        {
            this.enemyLevel = enemyLevel;
            isCompleted = false;
            this.typeOfEncounter = typeOfEncounter;
        }

        public virtual void StartEncounter()
        {
            // Implement the logic to start the encounter here.
        }

        public virtual void UpdateEncounter()
        {
            // Implement the logic to update the encounter (e.g., handle player actions and enemy AI).
        }

        public virtual void EndEncounter()
        {
            // Implement the logic to end the encounter (e.g., determine the outcome).
            isCompleted = true;
        }

        
    }





}

