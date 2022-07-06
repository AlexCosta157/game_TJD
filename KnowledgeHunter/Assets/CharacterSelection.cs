using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    public GameObject[] characters;
    
    public int sexSelected = 0;

    void Start()
    {
        characters[sexSelected].SetActive(true);
    }

    public void Nextcharacter()
    {
        characters[sexSelected].SetActive(false);
        sexSelected++;
        if (sexSelected >= characters.Length)
        {
            sexSelected = 0;
        }
        characters[sexSelected].SetActive(true);
    }

    public void PreviousCharacter()
    {
        characters[sexSelected].SetActive(false);
        sexSelected--;
        if(sexSelected < 0)
        {
            sexSelected += characters.Length;
        }
        characters[sexSelected].SetActive(true);
    }

    public void StartGame()
    {
        int armorLevel = 0;
        PlayerPrefs.SetInt("armorLevel", armorLevel);
        PlayerPrefs.SetInt("sexSelected", sexSelected);
        //PlayerPrefs.SetInt("wasInCastle", 0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
