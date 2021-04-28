using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour 
{	
    [SerializeField]
    private float speed;
 
 
    void FixedUpdate () 
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        Vector2 currentVelocity = gameObject.GetComponent<Rigidbody2D>().velocity;

        float newVelocityX = 0f;
        

        if (sceneName == "Battle")
        {
            return;
        }
        else
        {
        if(moveHorizontal < 0 && currentVelocity.x <= 0) 
        {
            newVelocityX = -speed;
            
        } 
        else if(moveHorizontal > 0 && currentVelocity.x >= 0) 
        {
            newVelocityX = speed;
         {
      // Pick a number between 0 and 100
            int value = Random.Range(0, 10000);
      
      // Check if the number is below the current threshold
            if (value < currentEncounterThreshold)
            {
        // If it is, then start an encounter, and set the threshold back to the default value for next time.
             SceneManager.LoadScene("Battle");
             currentEncounterThreshold = DEFAULT_ENCOUNTER_THRESHOLD;
            }
         else
        {
        // We weren't below the threshold this time, so let's increase it
             currentEncounterThreshold += 1;
         }
    }
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
   const int DEFAULT_ENCOUNTER_THRESHOLD = 10;
  
 
  private int currentEncounterThreshold = DEFAULT_ENCOUNTER_THRESHOLD;
  
  public void Update()
  {


  }
}