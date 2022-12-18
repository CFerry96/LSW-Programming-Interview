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

    void Start()
    {
        CreateDisplay();
    }
   
    void Update()
    {
        UpdateDisplay();
    }

    public void CreateDisplay()
    {
        for(int i = 0; i< inventory.Container.Count; i++)
        {
            var obj = Instantiate(inventory.Container[i].item.prefab, Vector2.zero, Quaternion.identity, transform);
            obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
        }
    }

    public Vector2 GetPosition(int i)
    {
        return new Vector2 ((X_SPACE_BETWEEN_ITEM *(i % NUMBER_OF_COLUMN)), (-Y_SPACE_BETWEEN_ITEMS * (i / NUMBER_OF_COLUMN)));
    }

    public void UpdateDisplay()
    {
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (itemsDisplayed.ContainsKey(inventory.Container[i]))
            {

            }
            else
            {
                var obj = Instantiate(inventory.Container[i].item.prefab, Vector2.zero, Quaternion.identity, transform);
                obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                itemsDisplayed.Add(inventory.Container[i], obj);
            }
        }
    }
}
