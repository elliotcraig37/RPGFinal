using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClassChoice : MonoBehaviour
{
   public GameObject Mage;
   public GameObject Warrior;
    private readonly string selectedCharacter = "SelectedCharacter";

    void Start()
    {
        
    }
    public void OnMageButton()
    {
        PlayerPrefs.SetInt(selectedCharacter, 1);
        SceneManager.LoadScene("Town");
    
    }
    public void OnWarriorButton()
    {
        PlayerPrefs.SetInt(selectedCharacter, 2);
        SceneManager.LoadScene("Town");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
