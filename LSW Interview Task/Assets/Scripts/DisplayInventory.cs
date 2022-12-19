using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayInventory : MonoBehaviour
{
    public InventoryObject inventory;

    public int X_SPACE_BETWEEN_ITEM;
    public int NUMBER_OF_COLUMN;
    public int Y_SPACE_BETWEEN_ITEMS;
    Dictionary<InventorySlot, GameObject> itemsDisplayed = new Dictionary<InventorySlot, GameObject>();

    void OnEnable()
    {
        itemsDisplayed = new Dictionary<InventorySlot, GameObject>();
        foreach (var slot in inventory.Container)
        {
            AddSlot(slot);
        }
    }

    private void OnDisable()
    {
        if (transform.childCount == 0)
            return;

        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }

    public Vector2 GetPosition(int i)
    {
        return new Vector2((X_SPACE_BETWEEN_ITEM * (i % NUMBER_OF_COLUMN)), (-Y_SPACE_BETWEEN_ITEMS * (i / NUMBER_OF_COLUMN)));
    }

    private void AddSlot(InventorySlot slotToAdd)
    {
        var obj = Instantiate(slotToAdd.item.prefab, Vector2.zero, Quaternion.identity, transform);
        itemsDisplayed.Add(slotToAdd, obj);
        obj.GetComponent<RectTransform>().localPosition = GetPosition(itemsDisplayed.Count - 1);
    }
}
