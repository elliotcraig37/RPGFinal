using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHUD : MonoBehaviour
{
    public GameObject Mage;
    public GameObject Warrior;
    private readonly string selectedCharacter = "SelectedCharacter";

    Unit playerUnit;

    public Text nameText;
    public Text potionsText;
    public Text manapotsText;

	public Slider hpSlider;
	public Slider Mana;

    // Start is called before the first frame update
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
    public void SetHUD(Unit unit)
    {
        nameText.text = unit.unitName;
		hpSlider.maxValue = unit.maxHP;
		hpSlider.value = unit.currentHP;
		Mana.value = unit.currentMana;
		Mana.maxValue = unit.maxMana;
        manapotsText.text = unit.ManaPots.ToString();
        potionsText.text = unit.Potions.ToString();
    }
    public void SetHP(int hp)
	{
		hpSlider.value = hp;
	}
	public void SetMana(int mana)
	{
		Mana.value = mana;
	}
}
