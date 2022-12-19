using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Default Object", menuName = "Inventory System/Items/Defaul")]

public class DefaultObject : ItemObject
{
    private void Awake()
    {
        //For creating a new inventory system
        type = ItemType.Default;
    }
}
