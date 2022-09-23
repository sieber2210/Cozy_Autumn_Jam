using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;

    private void Update()
    {
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
    }
}
