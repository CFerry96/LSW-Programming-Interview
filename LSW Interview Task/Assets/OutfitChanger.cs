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
    private int currentLegOption;
    
    public int CurrentTorsoOption
    {
        get{return currentTorsoOption;}
        set 
        {
            print("Setting value to:" + value);
            currentTorsoOption = value;
            print(currentTorsoOption);
        }
    }
    public int CurrentLegOption
    {
        get { return currentLegOption;}
        set
        {
            print("Setting value to:" + value);
            currentLegOption = value;
            print(currentLegOption);
        }
    }

    private void Awake()
    {
        CurrentTorsoOption = 0;
        CurrentLegOption = 0;
    }

    public void ChangeTop()
    {
        Torso.sprite = tops[CurrentTorsoOption];
        
    }
    public void ChangeBottom()
    {
        Legs.sprite = bottoms[CurrentLegOption];
    }

    public void ChangeTop(int topIndex)
    {
        CurrentTorsoOption = topIndex;
        ChangeTop();
    }

    public void ChangeBottom(int bottomIndex)
    {
        CurrentLegOption = bottomIndex;
        ChangeBottom();
    }
}


/* public void GreenTop()
   {
       CurrentTorsoOption = 0;
       ChangeTop();
   }

   public void OrangeTop()
   {
       CurrentTorsoOption = 1;
       ChangeTop();
   }

   public void BlueBottoms()
   {
       currentLegOption = 0;
       ChangeBottoms();
   }
   public void DarkBlueBottoms()
   {
       currentLegOption = 1;
       ChangeBottoms();
   }
  */