using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RawItemTooltip : Tooltip
{
    private const int MAX_ELEMENTS = 2;

    public ElementSprites elementSprites;

    // TODO: update this or make another tooltip to display prep method results instead.
    public void SetElements(List<Element> elements) {
        int i = 0;

        // Set sprites as applicable
        for (; i < MAX_ELEMENTS && i < elements.Count; i++)
        {
            transform.GetChild(i).gameObject.SetActive(true);
            transform.GetChild(i).GetComponent<Image>().sprite = elementSprites.sprites[(int)elements[i]];
        }

        // If the ingredient has only 0 or 1 elements, any unused element slots should be hidden
        for (; i < MAX_ELEMENTS; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
    }

    private void OnDisable()
    {
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(false);
    }
}
