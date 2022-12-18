using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopkeepMenu : MonoBehaviour
{

    private bool Browsing;
    private bool PlayerInArea;
    private BoxCollider2D Collider;
    private GameObject ShopMenu;

    // Start is called before the first frame update
    void Start()
    {
        Browsing = false;
        PlayerInArea = false;
        Collider = this.gameObject.GetComponent<BoxCollider2D>();
        ShopMenu = GameObject.FindGameObjectWithTag("ShopMenu");
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerInArea == true && Browsing == false && Input.GetKey(KeyCode.E))
        {
            Browsing = true;
        }
        else if (PlayerInArea == true && Browsing == true && Input.GetKey(KeyCode.X))
        {
            Browsing = false;
        }
        else if(PlayerInArea == false)
        {
            Browsing = false;
        }

        if (Browsing)
        {
            ShopMenu.SetActive(true);
        }
        else if (!Browsing)
        {
            ShopMenu.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            print("playerInArea");
            PlayerInArea = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInArea = false;
        }
    }
}
