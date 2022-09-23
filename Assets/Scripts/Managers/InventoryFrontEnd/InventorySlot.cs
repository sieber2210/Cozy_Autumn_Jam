using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    private Ingredient ingredient;

    public Ingredient GetIngredient()
    {
        return ingredient;
    }

    public void SetIngredient(Ingredient ingredient)
    {
        this.ingredient = ingredient;
        if (ingredient != null)
        {
            GetComponent<Image>().sprite = this.ingredient.sprite;
        }
        else
        {
            GetComponent<Image>().sprite = null;
        }
    }

    public bool IsSlotFull()
    {
        return ingredient != null;
    }
}
