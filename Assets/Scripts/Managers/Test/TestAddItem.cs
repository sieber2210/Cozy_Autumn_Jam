using UnityEngine;

public class TestAddItem : MonoBehaviour
{
    [SerializeField] TestUI testUI;

    const string circle = "Circle";
    const string square = "Square";
    const string cap = "Capsule";
    const string rounded = "Rounded";

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Managers.Inventory.AddItem(circle);
            testUI.AddItem();
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Managers.Inventory.AddItem(square);
            testUI.AddItem();
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Managers.Inventory.AddItem(cap);
            testUI.AddItem();
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Managers.Inventory.AddItem(rounded);
            testUI.AddItem();
        }
    }
}
