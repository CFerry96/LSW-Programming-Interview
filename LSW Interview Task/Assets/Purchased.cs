using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Purchased : MonoBehaviour
{
    public InventoryObject inventory;
    private GameObject soldOut;
    //public static GameManager gm;
    private bool sold;
    public int price;
    

    private void Awake()
    {
        soldOut = GameObject.Find("Sold Out");
        soldOut.SetActive(false);       
    }
    private void Start()
    {
        sold = false;
    }

    public void Bought()
    {
       
        if(!sold)
        {
            if(GameManager.instance.Cash > price)
            {
                var item = this.GetComponent<Item>();
                inventory.AddItem(item.item, 1);


                soldOut.SetActive(true);
                sold = true;
                GameManager.instance.Cash -= price;
            } 
        }
        else if (sold)
        {
            
        }
        
    }
}