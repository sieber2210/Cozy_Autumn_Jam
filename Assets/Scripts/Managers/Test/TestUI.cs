using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using TMPro;

public class TestUI : MonoBehaviour
{
    [SerializeField] List<GameObject> inventorySlots = new List<GameObject>();

    List<string> itemList = new List<string>();

    public void AddItem(string item)
    {
        itemList = Managers.Inventory.GetItemList();

        if (!itemList.Contains(item))
        {
            Managers.Inventory.AddItem(item);
            itemList = Managers.Inventory.GetItemList();

            if (inventorySlots[0].GetComponentInChildren<TextMeshProUGUI>().text == "")
            {
                inventorySlots[0].GetComponentInChildren<TextMeshProUGUI>().SetText(itemList[0]);
            }
            else
            {
                if (inventorySlots[1].GetComponentInChildren<TextMeshProUGUI>().text == "")
                {
                    inventorySlots[1].GetComponentInChildren<TextMeshProUGUI>().SetText(itemList[1]);
                }
                else
                {
                    if (inventorySlots[2].GetComponentInChildren<TextMeshProUGUI>().text == "")
                    {
                        inventorySlots[2].GetComponentInChildren<TextMeshProUGUI>().SetText(itemList[2]);
                    }
                    else
                    {
                        if (inventorySlots[3].GetComponentInChildren<TextMeshProUGUI>().text == "")
                        {
                            inventorySlots[3].GetComponentInChildren<TextMeshProUGUI>().SetText(itemList[3]);
                        }
                        else
                        {
                            Debug.Log("No more inventory slots");
                            return;
                        }
                    }
                }
            }
        }
        else
        {
            Debug.Log("Player already has a " + item);
            return;
        }
    }
}
