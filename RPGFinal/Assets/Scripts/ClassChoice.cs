using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClassChoice : MonoBehaviour
{
   public GameObject Mage;
   public GameObject Warrior;
    private readonly string selectedCharacter = "SelectedCharacter";
    public AddMoney AddMoney;
    Unit playerUnit;

    void Start()
    {
        
    }
    public void OnMageButton()
    {
        playerUnit = Mage.GetComponent<Unit>();
        playerUnit.Potions = 2;
        playerUnit.ManaPots = 1;
        PlayerPrefs.SetInt("CurrentMoney", 0);
        PlayerPrefs.SetInt(selectedCharacter, 1);
        SceneManager.LoadScene("Town");
    
    }
    public void OnWarriorButton()
    {
        playerUnit = Warrior.GetComponent<Unit>();
        playerUnit.Potions = 2;
        playerUnit.ManaPots = 1;
        PlayerPrefs.SetInt("CurrentMoney", 0);
        PlayerPrefs.SetInt(selectedCharacter, 2);
        SceneManager.LoadScene("Town");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
