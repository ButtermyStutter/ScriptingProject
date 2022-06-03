using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[Serializable]

public class IntEvent : UnityEvent<int> { }

public class GenericRaycast : MonoBehaviour
{
    private Ray g_ray = new Ray(); // Define a ray for this check 
    private RaycastHit g_hitObject; // Use the RaycastHit type to get an object hit 
    private bool g_isHit = false;
    public LayerMask g_layerToHit; // Defining a layer that will be detected with our raycast
    public float g_rayLength = 10f; // Length of the ray 
    public KeyCode g_boundKey; // store the key that executes raycast
    public IntEvent g_onObjectClicked;

    void Update()
    {
        if (Input.GetKeyDown(g_boundKey))
            CastRay();
        else if (Input.GetKeyUp(g_boundKey))
            g_isHit = false;
    }

    private void CastRay()
    {
        g_ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        // Creates a ray from the camera at the X & Y point of the mouse position 
        // Only really gets the direction of the ray - 'point to' <thing> 

        // Raycast function returns a boolean - returns an object hit to g_hitObject  
        if (Physics.Raycast(g_ray, out g_hitObject, g_rayLength, g_layerToHit))
        {
            if (g_isHit == false)
            {
                g_onObjectClicked.Invoke(g_hitObject.transform.GetComponent<WorldItem>().ID);

                g_isHit = true;
            }
        }
    }
}

