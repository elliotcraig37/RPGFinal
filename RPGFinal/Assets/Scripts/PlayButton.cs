using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{  
    AddMoney.SetInt("CurrentMoney", 0);

    public void loadNextScene() 
    {
        SceneManager.LoadScene("Town");
    }
}