using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;

    public GameObject[] tooltips;

    private void Update()
    {
        // Raycast when the player clicks to select something
        if (Input.GetMouseButtonDown(0)) {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit)) {
                if (hit.collider.GetComponent<Ingredient>() != null)
                {
                    hit.collider.GetComponent<Ingredient>().PickupItem();
                }
                else if (hit.collider.GetComponent<Cauldron>() != null)
                {
                    hit.collider.GetComponent<Cauldron>().CreatePotion();
                }
                else if (hit.collider.GetComponent<ThoughtBubble>() != null)
                {
                    hit.collider.GetComponent<ThoughtBubble>().AcceptRequest();
                }
            }
        }

        // Raycast to determine whether the player needs more information about a hovered object
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.GetComponent<Ingredient>() != null)
            {
                hit.collider.GetComponent<Ingredient>().ShowTooltip(Time.deltaTime);
            }
            else
            {
                // The player moved the mouse off of a hoverable object. Clear the tooltips
                foreach (GameObject tooltip in tooltips)
                {
                    tooltip.SetActive(false);
                }
            }
        }
    }
}
