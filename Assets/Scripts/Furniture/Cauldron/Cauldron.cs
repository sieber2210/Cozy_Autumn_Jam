using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cauldron : MonoBehaviour
{
    private List<Element> elements = new List<Element>();

    public void AddItem(Ingredient ingredient) {
        elements.AddRange(ingredient.elements);
        Debug.Log("Added Ingredient to cauldron");
    }

    public void CreatePotion() { }
}
