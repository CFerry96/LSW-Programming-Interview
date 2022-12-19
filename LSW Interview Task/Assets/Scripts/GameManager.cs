using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool isPaused;

    public int Cash;
    public Text Wallet;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;

        }
        else
        {
            if(instance != this)
            {
                Destroy(gameObject);
            }
        }
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        Wallet.text = Cash.ToString();
    }
}
