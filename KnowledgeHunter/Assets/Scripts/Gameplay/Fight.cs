using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fight : MonoBehaviour
{
    public GameObject[] maleCharacterPrefabs;
    public GameObject[] femaleCharacterPrefabs;
    public GameObject[] bossesPrefabs;
    public Transform bossSpawnPoint;
    public Transform charSpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        int sexSelected = PlayerPrefs.GetInt("sexSelected");

        if (sexSelected == 0)
        {
            int armorLevel = PlayerPrefs.GetInt("armorLevel");
            GameObject character = maleCharacterPrefabs[armorLevel];
            character.SetActive(true);
            character.transform.position = charSpawnPoint.position;
        }


        if (sexSelected == 1)
        {
            int armorLevel = PlayerPrefs.GetInt("armorLevel");
            GameObject character = femaleCharacterPrefabs[armorLevel];
            character.SetActive(true);
            character.transform.position = charSpawnPoint.position;
        }

        int selectedBoss = 0;//PlayerPrefs.GetInt("selectedBoss");


        GameObject boss = bossesPrefabs[selectedBoss];
        boss.SetActive(true);
        boss.transform.position = bossSpawnPoint.position;
    }
      

 
}
