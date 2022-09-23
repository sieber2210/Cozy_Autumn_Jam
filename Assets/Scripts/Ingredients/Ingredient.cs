using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient : MonoBehaviour
{
    public List<Element> elements;
    public Sprite sprite;

    public IngredientEvent ingredientPreppedEvent;

    public void PickupItem() {
        ingredientPreppedEvent.Raise(this);
    }
}
