using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST}

public class BattleSystem : MonoBehaviour
{
    public BattleState state;

    public GameObject[] maleCharacterPrefabs;
    public GameObject[] femaleCharacterPrefabs;
    public GameObject[] bossesPrefabs;

    public Transform bossSpawnPoint;
    public Transform charSpawnPoint;
    
    GameObject characterGO;
    GameObject bossGO;

    Unit characterUnit;
    Unit bossUnit;

    public Text dialogueText;

    // Start is called before the first frame update
    void Start()
    {
        state = BattleState.START;
        SetupBattle();

    }

    void SetupBattle()
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

        characterUnit = characterGO.GetComponent<Unit>();

        int selectedBoss = 0;
        bossGO = bossesPrefabs[selectedBoss];

        bossGO.SetActive(true);
        bossGO.transform.position = bossSpawnPoint.position;

        characterUnit = characterGO.GetComponent<Unit>();

        dialogueText.text = " Let's fight   " + characterUnit.unitName;
    }



}

