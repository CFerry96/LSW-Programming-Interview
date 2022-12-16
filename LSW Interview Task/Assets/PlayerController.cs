using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  

    private float moveHorizontal;
    private float moveVertical;
    
    [SerializeField]
    private float movementSpeed = 3f;
    

    void Start()
    {
        
    }


    void Update()
    {
        Vector2 moveDirection = Vector2.zero;
        this.moveHorizontal = Input.GetAxis("Horizontal"); // X-Axis
        this.moveVertical = Input.GetAxis("Vertical"); // Y-Axis

        if (moveHorizontal > 0)
        {
            moveDirection.x = 1;
            
        }
        else if (moveHorizontal < 0)
        {
            moveDirection.x = -1;
           
        }
        else if (moveVertical > 0)
        {
            moveDirection.y = 1;
            
        }
        else if (moveVertical < 0)
        {
            moveDirection.y = -1;
           
        }
        transform.Translate(moveDirection * movementSpeed * Time.deltaTime, Space.World);
    }
 
}
