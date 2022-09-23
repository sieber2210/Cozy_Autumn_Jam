using UnityEngine;
using UnityEngine.UI;

public class RequestedPotionDisplay : MonoBehaviour
{
    private const int MAX_RECIPE_SIZE = 8;

    public ElementSprites elementSprites;

    public void ShowRecipe(Recipe recipe)
    {
        int elementsShown = 0;
        foreach (Measure measure in recipe.recipe)
        {
            for (int i = 0; i < measure.amount; i++)
            {
                UpdateIcon(elementsShown, measure.element);
                elementsShown++;
                if (elementsShown >= MAX_RECIPE_SIZE) {
                    return;
                }
            }
        }
    }

    private void UpdateIcon(int index, Element element)
    {
        transform.GetChild(index).GetComponent<Image>().sprite = elementSprites.sprites[(int)element];
        transform.GetChild(index).gameObject.SetActive(true);
    }

    public void ClearRecipe(Boolean shouldClear) {
        if (shouldClear.value) {
            foreach (Transform child in transform) {
                child.gameObject.SetActive(false);
            }
        }
    }
}
