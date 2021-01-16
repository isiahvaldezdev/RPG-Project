using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Control
{
    public class PatrolPath : MonoBehaviour
    {
        const float waypointGozmoRadius = 0.3f;

        private void OnDrawGizmos()
        {
            for(int i = 0; i < transform.childCount ; i++)
            {
                Gizmos.DrawSphere(GetWaypoint(i).transform.position, waypointGozmoRadius);
                int nextIndex = GetNextIndex(i);
                Gizmos.DrawLine(GetWaypoint(i).transform.position, GetWaypoint(nextIndex).transform.position);
            }
        }

        public int GetNextIndex(int i)
        {
            return (i + 1) % transform.childCount;
        }

        public Transform GetWaypoint(int i)
        {
            return transform.GetChild(i);
        }
    }
}