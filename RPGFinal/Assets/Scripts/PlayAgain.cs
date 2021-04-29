using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    public AddMoney AddMoney;

    public void OnDeathButton()
    {
        PlayerPrefs.SetInt("CurrentMoney", 0);
        SceneManager.LoadScene("Town");
    }
}
