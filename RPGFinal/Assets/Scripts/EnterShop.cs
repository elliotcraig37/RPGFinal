using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterShop : MonoBehaviour
{
void OnTriggerEnter2d(Collider2D other)
{
    if (other.CompareTag("Player"))
    {
        SceneManager.LoadScene("Shop");
    }
}


}
