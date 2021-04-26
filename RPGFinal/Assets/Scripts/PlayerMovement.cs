using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{	
    [SerializeField]
    private float speed;
 

 
    void FixedUpdate () 
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
 
        Vector2 currentVelocity = gameObject.GetComponent<Rigidbody2D>().velocity;
 
        float newVelocityX = 0f;
 
        if(moveHorizontal < 0 && currentVelocity.x <= 0) 
        {
            newVelocityX = -speed;
            
        } 
        else if(moveHorizontal > 0 && currentVelocity.x >= 0) 
        {
            newVelocityX = speed;
           
        } 

 
        float newVelocityY = 0f;
 
        if(moveVertical < 0 && currentVelocity.y <= 0) 
        {
            newVelocityY = -speed;
            
        } 
        else if(moveVertical > 0 && currentVelocity.y >= 0) 
        {
            newVelocityY = speed;
            
        } 

 
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(newVelocityX, newVelocityY);
    }
}