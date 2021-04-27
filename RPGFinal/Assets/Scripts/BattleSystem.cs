using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }

public class BattleSystem : MonoBehaviour
{

	public GameObject playerPrefab;
	public GameObject enemy1;
	public GameObject enemy2;
	public GameObject enemy3;

	public int whichEnemy=1;

	public Transform playerBattleStation;
	public Transform enemyBattleStation;

	Unit playerUnit;
	Unit enemyUnit;

	public Text dialogueText;
	public AddMoney AddMoney;
	public BattleHUD playerHUD;
	public BattleHUD enemyHUD;

	public BattleState state;


    void Start()
    {	

		state = BattleState.START;
		StartCoroutine(SetupBattle());
    }

	IEnumerator SetupBattle()
	{
		GameObject playerGO = Instantiate(playerPrefab, playerBattleStation);
		playerUnit = playerGO.GetComponent<Unit>();
		whichEnemy = Random.Range(1,4);
			if (whichEnemy == 1)
				{GameObject enemyGO = Instantiate(enemy1, enemyBattleStation);
				enemyUnit = enemyGO.GetComponent<Unit>();}
			if (whichEnemy == 2)
				{GameObject enemyGO = Instantiate(enemy2, enemyBattleStation);
				enemyUnit = enemyGO.GetComponent<Unit>();}
			if (whichEnemy >= 3)
				{GameObject enemyGO = Instantiate(enemy3, enemyBattleStation);
				enemyUnit = enemyGO.GetComponent<Unit>();}

		dialogueText.text = "A " + enemyUnit.unitName + " attacks!";

		playerHUD.SetHUD(playerUnit);
		enemyHUD.SetHUD(enemyUnit);

		yield return new WaitForSeconds(2f);

		state = BattleState.PLAYERTURN;
		PlayerTurn();
	}

	IEnumerator PlayerAttack()
	{
		bool isDead = enemyUnit.TakeDamage(playerUnit.damage);

		enemyHUD.SetHP(enemyUnit.currentHP);
		dialogueText.text = "You Attack!";

		yield return new WaitForSeconds(2f);

		if(isDead)
		{
			state = BattleState.WON;
			EndBattle();
		} else
		{
			state = BattleState.ENEMYTURN;
			StartCoroutine(EnemyTurn());
		}
	}

	IEnumerator EnemyTurn()
	{
		dialogueText.text = enemyUnit.unitName + " attacks!";

		yield return new WaitForSeconds(1f);

		bool isDead = playerUnit.TakeDamage(enemyUnit.damage);

		playerHUD.SetHP(playerUnit.currentHP);

		yield return new WaitForSeconds(1f);

		if(isDead)
		{
			state = BattleState.LOST;
			EndBattle();
		} else
		{
			state = BattleState.PLAYERTURN;
			PlayerTurn();
		}

	}

	void EndBattle()
	{
		if(state == BattleState.WON)
		{
			dialogueText.text = "You won the battle! You gained " + enemyUnit.Gold + " Gold!";
			AddMoney.gainMoney(enemyUnit.Gold);
            void loadNextScene()
            {
                SceneManager.LoadScene("Town");
            }

		} else if (state == BattleState.LOST)
		{
			dialogueText.text = "You died.";
		}
	}

	void PlayerTurn()
	{
		dialogueText.text = "Choose an action:";
	}

	IEnumerator PlayerHeal()
	{
		playerUnit.Heal(15);

		playerHUD.SetHP(playerUnit.currentHP);
		dialogueText.text = "You drink the potion and feel better!";
		
		yield return new WaitForSeconds(2f);

		state = BattleState.ENEMYTURN;
		StartCoroutine(EnemyTurn());
	}

		public void OnAttackButton()
	{
		if (state != BattleState.PLAYERTURN)
			return;

		StartCoroutine(PlayerAttack());
	}
	public void OnHealButton()
	{
		
		if (state != BattleState.PLAYERTURN)
			return;
		if (playerUnit.Potions > 0)
		{
		StartCoroutine(PlayerHeal());
		}
		if (playerUnit.Potions == 0)
		{
			dialogueText.text = "You have no potions!";
			return;
		}
	}
	public void OnMagicButton()
	{
		if (state != BattleState.PLAYERTURN)
			return;
		if (playerUnit.currentMana == 0)
			{dialogueText.text = "You have no mana!";
			return;}
		else
		{
			StartCoroutine(PlayerMagicAttack());}
	}


	IEnumerator PlayerMagicAttack()
	{
		bool isDead = enemyUnit.TakeDamage(playerUnit.Magicdamage);

		enemyHUD.SetHP(enemyUnit.currentHP);
		dialogueText.text = "You Attack with a Fireball!";
		playerUnit.Magic(6);
		playerHUD.SetMana(playerUnit.currentMana);
		yield return new WaitForSeconds(2f);

		if(isDead)
		{
			state = BattleState.WON;
			EndBattle();
		} else
		{
			state = BattleState.ENEMYTURN;
			StartCoroutine(EnemyTurn());
		}
	}
}

