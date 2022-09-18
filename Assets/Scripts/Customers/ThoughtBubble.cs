using UnityEngine;

public class ThoughtBubble : MonoBehaviour
{
    // The child object containing the colorable contents of the requested potion should always be at this index.
    private const int ICON_COLOR = 1;

    public Recipes recipes;
    public RecipeEvent requestAcceptedEvent;

    private Recipe recipe;

    private void Start()
    {
        PickRecipe();
    }

    private void PickRecipe()
    {
        int rand = Random.Range(0, recipes.recipes.Length);
        recipe = recipes.recipes[rand] as Recipe;
        transform.GetChild(ICON_COLOR).GetComponent<SpriteRenderer>().color = recipe.thoughtBubbleColor;
    }

    public void AcceptRequest()
    {
        // raise event to set the recipe in HUD and product checkers
        requestAcceptedEvent.Raise(recipe);

        // preemptively pick another recipe for the next customer (this way, we don't need an event listener for potion completion here)
        PickRecipe();

        // disable me since you have your request now
        gameObject.SetActive(false);
    }
}
