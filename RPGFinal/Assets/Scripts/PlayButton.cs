using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{  

    public void OnPlayPressed()
    {
        SceneManager.LoadScene("Choose Class");
    }
}