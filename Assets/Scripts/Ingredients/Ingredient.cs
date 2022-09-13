using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient : MonoBehaviour
{
    public List<Element> elements;

    public IngredientEvent ingredientPreppedEvent;

    public void TossInCauldron() {
        ingredientPreppedEvent.Raise(this);
    }
}
