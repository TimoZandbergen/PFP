using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Houdt een positie bij om naartoe te bewegen
public class Waypoint : MonoBehaviour
{
    public Vector3 GetPosition()
    {
        return transform.position;
    }
}
