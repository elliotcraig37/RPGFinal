using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterShop : MonoBehaviour
{
void OnTriggerEnter2d(Collider2D col)
{
    if (col.CompareTag("Player"))
    {
        SceneManager.LoadScene("Shop");
    }
}


}
