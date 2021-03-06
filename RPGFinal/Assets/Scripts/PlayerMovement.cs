using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour 
{	
    [SerializeField]
    private float speed;
 
    public Animator animator;
    void FixedUpdate () 
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        Vector2 currentVelocity = gameObject.GetComponent<Rigidbody2D>().velocity;

        float newVelocityX = 0f;
        animator.SetFloat("Speed", newVelocityX);

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

            int value = Random.Range(0, 50000);
      

            if (value < currentEncounterThreshold)
            {
                if (sceneName == "EncounterField")
                {
             SceneManager.LoadScene("Battle");
             currentEncounterThreshold = DEFAULT_ENCOUNTER_THRESHOLD;
                }
            }
         else
        {

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