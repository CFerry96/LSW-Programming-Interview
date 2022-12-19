using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Purchased : MonoBehaviour
{
    public InventoryObject inventory;
    public GameObject soldOut;
    private bool sold;
    public int price;
    private void Awake()
    {  
        soldOut.SetActive(false);       
    }
    private void Start()
    {
        sold = false;
    }

    public void BuyOrSell()
    {
        //Determines wether you can buy or sell depending on wether you already have an item or not
        if(sold)
        {
            Sell();
        }
        else if(!sold)
        {
            Bought();
        }
    }

    public void Bought()
    {
        //Adds the bought item to the inventory 
        if (GameManager.instance.Cash > price)
        {
            var item = this.GetComponent<Item>();
            inventory.AddItem(item.item, 1);


            soldOut.SetActive(true);
            sold = true;
            GameManager.instance.Cash -= price;
            Debug.Log("Bought");
        }
    }

    public void Sell()
    {
        //Remove the sold item from the inventory
        var item = this.GetComponent<Item>();
        inventory.RemoveItem(item.item, 1);

        soldOut.SetActive(false);
        sold = false;
        GameManager.instance.Cash += price;

        Debug.Log("Sold");
    }
}
