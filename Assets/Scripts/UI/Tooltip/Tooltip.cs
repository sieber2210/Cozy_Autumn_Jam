using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tooltip : MonoBehaviour
{
    public Vector3 offset;

    /**
     * duplicating the Update() logic in OnEnable() prevents jerky / jittery movement of the tooltip
     * as there is a very brief period after enabling the tooltip where it is actually at its last 
     * location before being disabled. This shrinks that period.
     */
    private void OnEnable()
    {
        transform.position = Input.mousePosition + offset;
    }

    private void Update()
    {
        transform.position = Input.mousePosition + offset;
    }
}
