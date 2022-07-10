using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST}

public class BattleSystem : MonoBehaviour
{
    public BattleState state;

    public GameObject[] maleCharacterPrefabs;
    public GameObject[] femaleCharacterPrefabs;
    public GameObject[] bossPrefabs;

    public Transform bossSpawnPoint;
    public Transform charSpawnPoint;
    
    GameObject characterGO;
    GameObject bossGO;

    Unit characterUnit;
    Unit bossUnit;

    public Text dialogueText;

    public BattleHud characterHUD;
    public BattleHud bossHUD;

    void Start()
    {
        state = BattleState.START;
        StartCoroutine(SetupBattle());
    }

    IEnumerator SetupBattle() // co-rotine, sao uma especie de funcao que correm separadamente de todas as outras e podem ser passadas à frente sempre que quisermos
    {
        int sexSelected = PlayerPrefs.GetInt("sexSelected");
        int armorLevel = PlayerPrefs.GetInt("armorLevel");

        if (sexSelected == 0)
        {
            characterGO = maleCharacterPrefabs[armorLevel];
        }

        if (sexSelected == 1)
        {
            characterGO = femaleCharacterPrefabs[armorLevel];
        }

        characterGO.SetActive(true);
        characterGO.transform.position = charSpawnPoint.position;

        int selectedBoss = PlayerPrefs.GetInt("selectedBoss"); ;
        bossGO = bossPrefabs[selectedBoss];
        bossGO.SetActive(true);
        bossGO.transform.position = bossSpawnPoint.position;

        characterUnit = characterGO.GetComponent<Unit>();

        bossUnit = bossGO.GetComponent<Unit>();

        dialogueText.text = " Let's fight  " + bossUnit.unitName;

        characterHUD.SetHUD(characterUnit);
        bossHUD.SetHUD(bossUnit);

        yield return new WaitForSeconds(2f);

        state = BattleState.PLAYERTURN;
        PlayerTurn();
    }

    IEnumerator PlayerAttack()
    {
        bool isDead = bossUnit.TakeDamage(characterUnit.damage);

        bossHUD.SetHP(bossUnit.currentHP);
        dialogueText.text = " The attack is successful!!";

        yield return new WaitForSeconds(2f);
        
        
        if (isDead)
        {
            state = BattleState.WON;
            EndBattle();
        }
        else
        {
            state = BattleState.ENEMYTURN;
            StartCoroutine(BossAttack());

        }
        //change state based on what happend
    }
    IEnumerator BossAttack()
    {
        dialogueText.text = bossUnit.unitName + " atacks !";
        yield return new WaitForSeconds(1f);

        bool isDead = characterUnit.TakeDamage(bossUnit.damage);

        characterHUD.SetHP(characterUnit.currentHP);

        yield return new WaitForSeconds(1f);

        if (isDead)
        {
            state = BattleState.LOST;
            StartCoroutine(EndBattle());
        }
        else
        {
            state = BattleState.PLAYERTURN;
            PlayerTurn();

        }
    }

    IEnumerator EndBattle()
    {
        if (state == BattleState.WON)
        {
            dialogueText.text = " You WON the Battle !";
            
        }
        else if (state == BattleState.LOST)
        {
            dialogueText.text = " You were defeated !";
   
        }

        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(1);

    }

    void PlayerTurn()
    {
        dialogueText.text = " Choose an action:";
    }

   public void OnAttackButton(int attack)
   {
        if (state != BattleState.PLAYERTURN)
        {
            return;
        }

        StartCoroutine(PlayerAttack());
    }


}

