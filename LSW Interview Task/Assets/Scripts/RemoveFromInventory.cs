using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveFromInventory : MonoBehaviour
{
    public InventorySlot iSlot;


    void Update()
    {
        Debug.Log("WooHoo");
        if(iSlot.empty == true)
        {
            Destroy(this.gameObject);
        }
    }
}
