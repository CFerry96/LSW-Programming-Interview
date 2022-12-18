using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIItemLegs : MonoBehaviour
{
    [SerializeField] private Button button;

    [SerializeField] private int legIndex = 1;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        var outfitChanger = FindObjectOfType<OutfitChanger>();
        button.onClick.AddListener(() => outfitChanger.ChangeBottom(legIndex));
    }
}
