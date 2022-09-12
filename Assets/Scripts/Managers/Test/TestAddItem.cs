using UnityEngine;

public class TestAddItem : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            Managers.Inventory.AddItem("Circle");

        if (Input.GetKeyDown(KeyCode.Alpha2))
            Managers.Inventory.AddItem("Square");

        if (Input.GetKeyDown(KeyCode.Alpha3))
            Managers.Inventory.AddItem("Capsule");

        if (Input.GetKeyDown(KeyCode.Alpha4))
            Managers.Inventory.AddItem("health");
    }
}
