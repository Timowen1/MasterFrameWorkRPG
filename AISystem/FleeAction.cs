using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MasterFrameWorkRPG.AIFrameWork
{
    public class FleeAction : GOAP_Action
    {
        private Transform charPos;
        private Vector3 fleeDestination;  // Destination to flee to
        private float fleeSpeed = 5.0f;  // Speed at which to flee

        public FleeAction(Vector3 destination, Transform position) : base("Flee")
        {
            Preconditions.Add("IsIdle", true);
            Effects.Add("IsIdle", false);
            Effects.Add("IsFleeing", true);

            fleeDestination = destination;
            charPos = position;
        }

        public override bool Execute()
        {
            // Move towards the flee destination
            MoveTowardsFleeDestination();

            // Check if the AI has reached the flee destination
            if (Vector3.Distance(charPos.position, fleeDestination) < 1.0f)
            {
                // Flee action completed
                return true;
            }

            // Flee action in progress
            return false;
        }

        private void MoveTowardsFleeDestination()
        {
            // Move the AI towards the flee destination at a constant speed
            charPos.position = Vector3.MoveTowards(charPos.position, fleeDestination, fleeSpeed * Time.deltaTime);
        }
    }

}
