using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopkeepMenu : MonoBehaviour
{

    private bool Browsing;
    private bool PlayerInArea;
    private BoxCollider2D Collider;
    private GameObject ShopMenu, Ekey, IKey;

    // Start is called before the first frame update
    void Start()
    {
        Browsing = false;
        PlayerInArea = false;
        Collider = this.gameObject.GetComponent<BoxCollider2D>();
        ShopMenu = GameObject.FindGameObjectWithTag("ShopMenu");
        Ekey = GameObject.Find("EKey");
        IKey = GameObject.Find("IKey");
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerInArea == true && Browsing == false && Input.GetKey(KeyCode.E))
        {
            Browsing = true;
            Ekey.SetActive(false);
        }
        else if (PlayerInArea == true && Browsing == true && Input.GetKey(KeyCode.X))
        {
            Browsing = false;
            Ekey.SetActive(true);
        }
        else if(PlayerInArea == false)
        {
            Browsing = false;
            Ekey.SetActive(false);
            
        }

        if (Browsing)
        {
            ShopMenu.SetActive(true);
            IKey.SetActive(false);

        }
        else if (!Browsing)
        {
            ShopMenu.SetActive(false);
            IKey.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            print("playerInArea");
            PlayerInArea = true;
            Ekey.SetActive(true);

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
