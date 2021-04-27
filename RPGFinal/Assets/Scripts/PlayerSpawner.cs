using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject MagePlayer;
    public GameObject WarriorPlayer;
    public Transform StartPoint;

    // Start is called before the first frame update
    void Start(Unit unit)
    {
        if (ClassChoice.Mage == true)
        {
            Instantiate(MagePlayer, StartPoint);
        }
        if (ClassChoice.Warrior == true)
        {
            Instantiate(WarriorPlayer, StartPoint);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
