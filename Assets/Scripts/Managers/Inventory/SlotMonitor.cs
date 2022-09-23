using UnityEngine;

public class SlotMonitor : MonoBehaviour
{
    public void StoreItem(Ingredient item) {
        foreach (Transform slot in transform) {
            if (!slot.GetComponent<InventorySlot>().IsSlotFull()) {
                slot.GetComponent<InventorySlot>().SetIngredient(item);
                return;
            }
        }
    }
}
