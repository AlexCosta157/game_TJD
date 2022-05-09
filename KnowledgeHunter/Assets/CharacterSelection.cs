using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    public GameObject[] characters;
    public int selectedCharacter=0;

    void Start()
    {
        characters[selectedCharacter].SetActive(true);
    }

    public void Nextcharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter++;
        if (selectedCharacter >= characters.Length)
        {
            selectedCharacter = 0;
        }
        characters[selectedCharacter].SetActive(true);
    }

    public void PreviousCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if(selectedCharacter < 0)
        {
            selectedCharacter += characters.Length;
        }
        characters[selectedCharacter].SetActive(true);
    }

    public void StartGame()
    {
        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
