using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitChanger : MonoBehaviour
{
    public SpriteRenderer Torso, Legs;
    public List<Sprite> bottoms = new List<Sprite>();
    public List<Sprite> tops = new List<Sprite>();
    public int currentTorsoOption = 0;
    public int currentLegOption = 0;

    public void Update()
    {
        ChangeTop();
        ChangeBottoms();
    }

    public void ChangeTop()
    {
        Torso.sprite = tops[currentTorsoOption];
        
    }
    public void ChangeBottoms()
    {
        Legs.sprite = bottoms[currentLegOption];
    }

    public void GreenTop()
    {
        currentTorsoOption = 0;
    }

    public void OrangeTop()
    {
        currentTorsoOption = 1;
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
