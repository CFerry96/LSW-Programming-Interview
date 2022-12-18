using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    public InventoryObject inventory;

    private Rigidbody2D rb;
    private float moveHorizontal;
    private float moveVertical;
    
    public int equippedTop;
    public int equippedBottom;

    [SerializeField]
    private float movementSpeed = 3f;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }


    void Update()
    {
        this.moveHorizontal = Input.GetAxis("Horizontal") * movementSpeed; // X-Axis
        this.moveVertical = Input.GetAxis("Vertical") * movementSpeed; // Y-Axis

        rb.velocity = new Vector2(moveHorizontal, moveVertical);

        
        //bottoms[1] = GameObject.FindWithTag("Blue");
        //bottoms[2] = GameObject.FindWithTag("DarkBlue");

        //tops.Add(GameObject.FindWithTag("Green"));
        //tops.Add(GameObject.FindWithTag("Orange"));
       // Clothes();
    }

    private void OnApplicationQuit()
    {
        inventory.Container.Clear();
    }

    public void Clothes()
    {
        
    }

}
