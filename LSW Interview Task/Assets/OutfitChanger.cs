using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutfitChanger : MonoBehaviour
{
    public SpriteRenderer Torso, Legs;
    public List<Sprite> bottoms = new List<Sprite>();
    public List<Sprite> tops = new List<Sprite>();
    private int currentTorsoOption;
    public int currentLegOption;
    
    public int CurrentTorsoOption
    {
        get{ return currentTorsoOption; }
        set 
        {
            currentTorsoOption = value;
            print("Setting value to:" + value);
        }
    }

    private void Awake()
    {
        CurrentTorsoOption = 0;
        currentLegOption = 0;
    }
    public void Update()
    {
        ChangeTop();
        ChangeBottoms();
    }

    public void ChangeTop()
    {
        Torso.sprite = tops[CurrentTorsoOption];
        
    }
    public void ChangeBottoms()
    {
        Legs.sprite = bottoms[currentLegOption];
    }

    public void GreenTop()
    {
        Debug.Log(CurrentTorsoOption);
        CurrentTorsoOption = 0;
        Debug.Log(CurrentTorsoOption);
    }

    public void OrangeTop()
    {
        Debug.Log(CurrentTorsoOption);
        CurrentTorsoOption = 1;
        Debug.Log(CurrentTorsoOption);
    }

    public void BlueBottoms()
    {
        currentLegOption = 0;
    }
    public void DarkBlueBottoms()
    {
        currentLegOption = 1;
    }
}
