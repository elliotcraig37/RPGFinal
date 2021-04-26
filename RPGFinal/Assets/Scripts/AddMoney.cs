using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMoney : MonoBehaviour
{
   public int playerMoney = 0;

   void addPlayerMoney(addAmount){
       playerMoney += addAmount;
   }
}
