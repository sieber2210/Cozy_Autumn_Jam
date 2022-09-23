using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cauldron : MonoBehaviour
{
    private static Vector3 ABOVE_CAULDRON = new Vector3(0f, 5f, 0f);
    private static Vector3 POTION_SCALE = new Vector3(1f, 1f, 1f);

    public Recipes recipes;
    public Transform customerLocation;
    public BooleanEvent requestSatisfiedEvent;

    // the parent transform itself of the inventory slots
    public Transform inventory;

    private List<Element> elements = new List<Element>();
    private Recipe expectedRecipe;

    private void MixIngredients() {
        foreach (Transform slot in inventory) {
            Ingredient ingredient = slot.GetComponent<InventorySlot>().GetIngredient();
            if (ingredient != null) {
                elements.AddRange(ingredient.elements);
                slot.GetComponent<InventorySlot>().SetIngredient(null);
            }
        }
    }

    public void CreatePotion()
    {
        MixIngredients();

        Recipe recipe = recipes.GetRecipe(elements);
        if (recipe == null)
        {
            // Explode and Clear elements
            Debug.Log("Kaboom! The potion exploded!");
            elements = new List<Element>();
            return;
        }
        else
        {
            // instantiate recipe.potionPrefab at Cauldron position + ABOVE_CAULDRON
            // the above vector puts the potion floating slightly above the Cauldron
            GameObject potion = Instantiate(
                recipe.potionPrefab,
                transform.position + ABOVE_CAULDRON,
                Quaternion.identity,
                transform
            );

            // the scale does not match the prefab. Not sure why. Reset it here.
            potion.transform.localScale = POTION_SCALE;
            potion.GetComponent<GiveToCustomerAnimation>().StartAnimation(customerLocation.position);

            // check whether the created potion matches the request. Notify every object listening for it.
            Debug.Log("potion matches " + expectedRecipe.Matches(recipe.recipe));
            Boolean b = new Boolean();
            b.value = expectedRecipe.Matches(recipe.recipe);
            requestSatisfiedEvent.Raise(b);
        }
        elements = new List<Element>();
    }

    public void SetExpectedRecipe(Recipe recipe) {
        expectedRecipe = recipe;
    }
}
