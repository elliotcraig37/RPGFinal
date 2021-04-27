using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopSystem : MonoBehaviour
{
    public GameObject Mage;
    public GameObject Warrior;

    public AddMoney AddMoney;
    Unit playerUnit;
    Unit shopUnit;

    private readonly string selectedCharacter = "SelectedCharacter";

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
    // Start is called before the first frame update
    void OnPotionButton()
    {
        playerUnit.PotionBuy(1);
        AddMoney.gainMoney(-10);
    }

    void OnManaButton()
    {
        playerUnit.ManaBuy(1);
        AddMoney.gainMoney(-20);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
