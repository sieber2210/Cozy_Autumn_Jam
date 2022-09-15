using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cauldron : MonoBehaviour
{
    private static Vector3 ABOVE_CAULDRON = new Vector3(0f, 2.75f, 0f);
    private static Vector3 POTION_SCALE = new Vector3(1f, 2f, 1f);

    public Recipes recipes;

    private List<Element> elements = new List<Element>();

    public void AddItem(Ingredient ingredient)
    {
        elements.AddRange(ingredient.elements);
        Debug.Log("Added Ingredient to cauldron");
    }

    public void CreatePotion()
    {
        Recipe recipe = recipes.GetRecipe(elements);
        if (recipe == null)
        {
            // Explode and Clear elements
            Debug.Log("Kaboom! The potion exploded!");
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
        }
        elements = new List<Element>();
    }
}
