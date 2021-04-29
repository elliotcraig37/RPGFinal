using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ToField : MonoBehaviour
{
    public Text dialogueText;
   public void OnFieldPressed()
    {
        StartCoroutine(EnterField());

    }
    public void OnShopPressed()
    {
        StartCoroutine(EnterShop());
    }
    IEnumerator EnterShop()
    {
     dialogueText.text = "You enter the familiar shop...";
     yield return new WaitForSeconds(2f);
      SceneManager.LoadScene("Shop");
    }
    IEnumerator EnterField()
    {
        dialogueText.text = "You head out to defend the village...";
        yield return new WaitForSeconds(2f);
      SceneManager.LoadScene("EncounterField");
    }
    public void OnTownPressed()
    {
        StartCoroutine(EnterTown());
    }
    IEnumerator EnterTown()
    {
        dialogueText.text = "You return to town, exhausted from your adventures...";
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Town");
    }
    
}
