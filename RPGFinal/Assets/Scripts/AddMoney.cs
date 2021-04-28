﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddMoney : MonoBehaviour {

public Text moneyText;
public int currentGold;

void Start()
{  
    if(PlayerPrefs.HasKey("CurrentMoney"))
    {
        currentGold = PlayerPrefs.GetInt("CurrentMoney");
    }
    else
    {
        currentGold = 0;
        PlayerPrefs.SetInt("CurrentMoney", 0);
    }
    moneyText.text = "Gold: " + currentGold;
}

void Update()
{

}


public void gainMoney(int goldToAdd)
{
    currentGold += goldToAdd;
    PlayerPrefs.SetInt("CurrentMoney", currentGold);
    moneyText.text = "Gold: " + currentGold;
}
}