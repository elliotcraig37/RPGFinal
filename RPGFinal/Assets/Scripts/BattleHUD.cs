using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHUD : MonoBehaviour
{

	public Text nameText;
	public Text manapotsText;
	public Text potionsText;

	public Slider hpSlider;
	public Slider Mana;

	public void SetHUD(Unit unit)
	{
		nameText.text = unit.unitName;
		hpSlider.maxValue = unit.maxHP;
		hpSlider.value = unit.currentHP;
		Mana.value = unit.currentMana;
		Mana.maxValue = unit.maxMana;
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
