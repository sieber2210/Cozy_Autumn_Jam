using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using TMPro;

public class TestUI : MonoBehaviour
{
    [SerializeField] List<GameObject> inventorySlots = new List<GameObject>();

    List<string> itemList = new List<string>();

    private void Start()
    {
        //StartCoroutine(UITick());
    }

    public void AddItem()
    {
        itemList = Managers.Inventory.GetItemList();

        if(inventorySlots[0].GetComponentInChildren<TextMeshProUGUI>().text == "")
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

    IEnumerator UITick()
    {
        while (true)
        {
            yield return new WaitForSeconds(10.0f);
            AddItem();
        }
    }

    /*private void OnGUI()
    {
        int posX = 10;
        int posY = 10;
        int width = 100;
        int height = 30;
        int buffer = 10;

        List<string> itemList = Managers.Inventory.GetItemList();
        if (itemList.Count == 0)
            GUI.Box(new Rect(posX, posY, width, height), "No Items");

        foreach (string item in itemList)
        {
            int count = Managers.Inventory.GetItemCount(item);
            Texture2D image = Resources.Load<Texture2D>($"Icons/{item}");
            GUI.Box(new Rect(posX, posY, width, height), new GUIContent($"({count})", image));


            if (item == "health")
            {
                if (GUI.Button(new Rect(posX, posY + height + buffer, width, height), "Use Health"))
                {
                    if (Managers.Player.health >= Managers.Player.maxHealth)
                    {
                        Debug.Log("Player already at full health. Cannot heal more!");
                    }
                    else if (Managers.Player.health < Managers.Player.maxHealth)
                    {
                        Managers.Inventory.ConsumeItem("health");
                        Managers.Player.ChangeHealth(25);
                    }
                }
            }

            posX += width + buffer;
        }
    }*/
}
