using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject MagePlayer;
    public GameObject WarriorPlayer;
    public Transform StartPoint;
    public PlayerHUD HUD;

    Unit playerUnit;
    private readonly string selectedCharacter = "SelectedCharacter";
    // Start is called before the first frame update
    void Start()
    {   int getCharacter;

       getCharacter = PlayerPrefs.GetInt(selectedCharacter);

        switch(getCharacter)
        {
            case 1:
                Instantiate(MagePlayer, StartPoint);
                playerUnit = MagePlayer.GetComponent<Unit>();
                break;
            case 2:
                Instantiate(WarriorPlayer, StartPoint);
                playerUnit = WarriorPlayer.GetComponent<Unit>();
                break;
        }
        HUD.SetHUD(playerUnit);
    }
    void Awake()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
