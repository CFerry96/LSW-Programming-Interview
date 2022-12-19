using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Purchased : MonoBehaviour
{
    public InventoryObject inventory;
    private GameObject soldOut;
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

    public void BuyOrSell()
    {
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

        var item = this.GetComponent<Item>();
        inventory.RemoveItem(item.item, 1);

        soldOut.SetActive(false);
        sold = false;
        GameManager.instance.Cash += price;

        Debug.Log("Sold");
    }
}
