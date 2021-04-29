using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopSystem : MonoBehaviour
{
    public GameObject Mage;
    public GameObject Warrior;
    public Text shopText;

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
        shopText.text = "Welcome! What can I get you?";
    }
    // Start is called before the first frame update
   public void OnPotionButton()
    {   if (AddMoney.currentGold >= 10)
        {
            playerUnit.PotionBuy(1);
            AddMoney.gainMoney(-10);
            shopText.text = "Pleasure doing business!";
        }
        else
        {
            shopText.text = "You don't have enough gold, sorry!";
            return;
        }
    }

   public void OnManaButton()
    {   if (AddMoney.currentGold >= 20)
        {
         playerUnit.ManaBuy(1);
         AddMoney.gainMoney(-20);
         shopText.text = "Pleasure doing business!";
        }
        else
        {
            shopText.text = "You don't have enough gold, sorry!";
        }
    }

   public void OnExitButton()
    {
        StartCoroutine(Exit());
    }
    IEnumerator Exit()
    {
        shopText.text = "Bye! Come back soon!";
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Town");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
