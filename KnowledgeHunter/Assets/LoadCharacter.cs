using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LoadCharacter : MonoBehaviour
{
    public GameObject[] maleCharacterPrefabs;
    public GameObject[] femaleCharacterPrefabs;
    public Transform spawnPoint;
    public Transform spanwCastle;
    GameObject character;

    void Start()
    {
        
        int armorLevel = PlayerPrefs.GetInt("armorLevel");
        int sexSelected = PlayerPrefs.GetInt("sexSelected");
        int spawnMode= PlayerPrefs.GetInt("wasInCastle");

        
        if (sexSelected == 0)
        {
            character = maleCharacterPrefabs[armorLevel];
            character.SetActive(true);
            character.transform.position = spawnPoint.position;


        }

        if (sexSelected == 1)
        {
            character = femaleCharacterPrefabs[armorLevel];
            character.SetActive(true);
            character.transform.position = spawnPoint.position;

        }

        /*switch (spawnMode)
        {
            case 0:
                character.transform.position = spawnPoint.position;
                break;
            case 1:
                character.transform.position = spanwCastle.position;
                break;

        }*/
        
    }
    
}


