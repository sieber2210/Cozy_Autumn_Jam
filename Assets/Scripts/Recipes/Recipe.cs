using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Recipe", menuName = "Recipe", order = 0)]
public class Recipe : ScriptableObject
{
    public List<Measure> recipe;

    // the prefab that should be rendered when this potion is created.
    public GameObject potionPrefab;

    public bool Matches(List<Measure> measures) {
        // same number of elements were used
        if (measures != null && measures.Count == recipe.Count) {

            // check that all measures given are in the recipe
            foreach (Measure measure in measures) {
                if (!recipe.Contains(measure)) {
                    return false;
                }
            }
            return true;
        }
        return false;
    }
}
