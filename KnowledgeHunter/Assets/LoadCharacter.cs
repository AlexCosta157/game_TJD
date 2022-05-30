using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadCharacter : MonoBehaviour
{
    public GameObject[] characterPrefabs;
    public Transform spawnPoint;
    //public TMP_Text label;

    void Start()
    {

        int selectedCharacter =PlayerPrefs.GetInt("selectedCharacter");
        GameObject prefab = characterPrefabs[selectedCharacter];
        prefab.SetActive(true);
        prefab.transform.position = spawnPoint.position;
        //prefab.transform.rotation = spawnPoint.rotation;

        /*GameObject prefab = characterPrefabs[selectedCharacter];
        prefab.SetActive(true);
        prefab.transform.position = spawnPoint.position;
        prefab.transform.rotation = spawnPoint.rotation;
        GameObject clone =  (GameObject) Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
        
        clone.AddComponent(Movement
            );*/
        //label.text = prefab.name;
    }


}
