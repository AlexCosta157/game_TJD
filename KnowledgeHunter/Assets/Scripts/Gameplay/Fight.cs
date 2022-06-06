using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fight : MonoBehaviour
{
    public GameObject[] characterPrefabs;
    public GameObject[] bossesPrefabs;
    public Transform bossSpawnPoint;
    public Transform charSpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
        int selectedBoss = 0;//PlayerPrefs.GetInt("selectedBoss");


        GameObject boss = bossesPrefabs[selectedBoss];
        boss.SetActive(true);
        boss.transform.position = bossSpawnPoint.position;

        GameObject character = characterPrefabs[selectedCharacter];
        character.SetActive(true);
        character.transform.position = charSpawnPoint.position;
    }

 
}
