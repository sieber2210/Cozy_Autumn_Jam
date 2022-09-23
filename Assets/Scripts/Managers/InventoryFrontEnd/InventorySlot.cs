using UnityEngine;

public class InventorySlot : MonoBehaviour
{
    Ingredient ingredient;

    public Ingredient GetIngredient()
    {
        return ingredient;
    }

    public void SetIngredient(Ingredient _ingredient)
    {
        ingredient = _ingredient;
    }

    public bool IsSlotFull()
    {
        if(ingredient is not null)
        {
            Debug.Log(gameObject.name + " currently has an item");
            return true;
        }
        else
        {
            return false;
        }
    }
}
