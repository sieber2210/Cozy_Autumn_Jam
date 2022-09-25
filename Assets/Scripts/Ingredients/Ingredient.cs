using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient : MonoBehaviour
{
    public List<Element> elements;
    public Sprite sprite;

    public IngredientEvent ingredientPreppedEvent;

    public Transform tooltip;
    private const float TOOLTIP_DELAY = 0.3f;
    private float timer;

    public void PickupItem() {
        ingredientPreppedEvent.Raise(this);
    }

    public void ShowTooltip(float deltaTime)
    {
        timer += deltaTime;
        if (timer >= TOOLTIP_DELAY)
        {
            timer = 0f;
            tooltip.gameObject.SetActive(true);
            tooltip.GetComponent<RawItemTooltip>().SetElements(elements);
        }
    }
}
