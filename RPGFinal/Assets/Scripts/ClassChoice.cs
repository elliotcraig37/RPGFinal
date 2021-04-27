using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClassChoice : MonoBehaviour
{
   public bool Mage;
   public bool Warrior;

    void Start()
    {
        
    }
    public void OnMageButton()
    {
        Mage = true;
        Warrior = false;
        SceneManager.LoadScene("Town");
    
    }
    public void OnWarriorButton()
    {
        Mage = false;
        Warrior = true;
        SceneManager.LoadScene("Town");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
