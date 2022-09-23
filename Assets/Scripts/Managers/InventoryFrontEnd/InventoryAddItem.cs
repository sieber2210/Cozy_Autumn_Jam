using UnityEngine;

public class InventoryAddItem : MonoBehaviour
{
    [SerializeField] InventoryUI testUI;

    const string circle = "Circle";
    const string square = "Square";
    const string cap = "Capsule";
    const string rounded = "Rounded";
    const string diamond = "Diamond";

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            testUI.AddItem(circle);
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            testUI.AddItem(square);
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            testUI.AddItem(cap);
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            testUI.AddItem(rounded);
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            testUI.AddItem(diamond);
        }
    }
}
