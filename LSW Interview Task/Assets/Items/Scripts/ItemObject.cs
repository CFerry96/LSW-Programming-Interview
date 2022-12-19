using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//For creating the Item Prefabs/Scriptables
public enum ItemType
{
    Default,
    BlueJeans,
    DarkBlueJeans,
    GreenJacket,
    OrangeJacket,
}

public abstract class ItemObject : ScriptableObject
{
    public GameObject prefab;
    public ItemType type;
    [TextArea(15, 20)]
    public string description;
}
