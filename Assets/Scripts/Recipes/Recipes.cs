using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recipes : MonoBehaviour
{
    public Object[] recipes;

    // Awake is called before Start. Any internal state initialization that needs to be done should be done here if possible.
    // If initialization depends on other GameObjects existing first, it is unsafe to use Awake as they will not be initialized
    // until their Awake function is called. Use Start instead.
    public void Awake()
    {
        recipes = Resources.LoadAll("ScriptableObjects/Recipes", typeof(Recipe));
        foreach (var r in recipes) {
            Debug.Log("Loaded recipe " + r.name);
        }
        Debug.Log("Finished Loading Recipes");
    }

    public Recipe GetRecipe(List<Element> elements) {
        List<Measure> measures = ConvertElementsToMeasures(elements);
        foreach (Recipe recipe in recipes) {
            if (recipe.Matches(measures)) {
                return recipe;
            }
        }
        return null;
    }

    private List<Measure> ConvertElementsToMeasures(List<Element> elements) {
        HashSet<Element> elementsUsed = new HashSet<Element>(elements);
        List<Measure> measures = new List<Measure>();
        foreach (Element elementUsed in elementsUsed)
        {
            int count = elements.FindAll(e => e == elementUsed).Count;
            measures.Add(new Measure(elementUsed, count));
        }
        return measures;
    }
}
