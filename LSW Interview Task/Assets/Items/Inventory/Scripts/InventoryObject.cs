using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory System/Inventory")]
public class InventoryObject : ScriptableObject
{
    public List<InventorySlot> Container = new List<InventorySlot>();
    public void AddItem(ItemObject _item, int _amount)
    {
        var newSlot = new InventorySlot(_item, _amount);
        Container.Add(newSlot);
    }

    public void RemoveItem(ItemObject _item, int _amount)
    {
        var slotIndex = Container.FindIndex(slot => slot.item.prefab == _item.prefab);

        if (slotIndex == -1)
            return;

        Container.RemoveAt(slotIndex);
    }
}

[System.Serializable]
public class InventorySlot
{
    public ItemObject item;
    public int amount;
    public bool empty;
    public InventorySlot(ItemObject _item, int _amount)
    {
        item = _item;
        amount = _amount;
    }

    public void AddAmount(int value)
    {
        amount += value;
        empty = false;
    }
    public void RemoveAmount(int value)
    {
        amount -= value;
        if(amount == 0)
        {
            empty = true;
        }
    }
}
