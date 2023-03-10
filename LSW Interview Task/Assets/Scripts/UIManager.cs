using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject inventoryMenu;

    private void Start()
    {
        inventoryMenu.gameObject.SetActive(false);
    }

    void Update()
    {
        InventoryControl();
        End();
    }
    private void InventoryControl()
    {
        //Opens Inventory
        if(Input.GetKeyDown(KeyCode.I))
        {
            if(GameManager.instance.isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    private void End()
    {
        //Ends Game
        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    private void Resume()
    {
        inventoryMenu.gameObject.SetActive(false);
        //Time.timeScale = 1.0f;
        GameManager.instance.isPaused = false;
    }

    private void Pause()
    {
        inventoryMenu.gameObject.SetActive(true);
        //Time.timeScale = 0.0f;
        GameManager.instance.isPaused = true;
    }
}
