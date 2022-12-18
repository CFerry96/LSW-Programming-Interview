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
    }

    private void OnApplicationQuit()
    {
        inventory.Container.Clear();
    }

}
