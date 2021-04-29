using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    public AddMoney AddMoney;
    public GameObject Mage;
	public GameObject Warrior;
    private readonly string selectedCharacter = "SelectedCharacter";
    Unit playerUnit;
    void Start()
    {
        int getCharacter;

        getCharacter = PlayerPrefs.GetInt(selectedCharacter);

        switch(getCharacter)
		{
			case 1:
				playerUnit = Mage.GetComponent<Unit>();
				break;
			case 2:
				playerUnit = Warrior.GetComponent<Unit>();
				break;
		}
    }
    public void OnDeathButton()
    {   playerUnit.Potions = 2;
        playerUnit.ManaPots = 1;
        PlayerPrefs.SetInt("CurrentMoney", 0);
        SceneManager.LoadScene("Town");
    }
}
