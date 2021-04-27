using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopSystem : MonoBehaviour
{
    public GameObject Mage;
    public GameObject Warrior;
    public GameObject Shop;

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
        shopUnit = Shop.GetComponent<Unit>();
    }
    // Start is called before the first frame update
    void OnPotionButton()
    {
        
    }

    void OnManaButton()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
