using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{

	public string unitName;


	public int damage;
	public int Magicdamage;

	public int maxHP;
	public int currentHP;

	public int maxMana;
	public int currentMana;

	public int Gold;
	public int Potions;
	public int ManaPots;

	public bool TakeDamage(int dmg)
	{
		currentHP -= dmg;

		if (currentHP <= 0)
			return true;
		else
			return false;
	}
	public bool Magic(int amount)
	{
		currentMana -= amount;
		if (currentMana <= 0)
			return true;
		else
			return false;
	}
	public void MagicHeal(int amount)
	{
		currentMana += amount;
		if (currentMana > maxMana)
			currentMana = maxMana;
		ManaPots -= 1;
	}

	public void Heal(int amount)
	{

		currentHP += amount;
		if (currentHP > maxHP)
			currentHP = maxHP;
		Potions -= 1;

	}
		

}
