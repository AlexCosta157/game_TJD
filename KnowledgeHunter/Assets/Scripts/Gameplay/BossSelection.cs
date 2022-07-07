using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BossSelection : MonoBehaviour
{

    public void SelectBoss(int index)
    {
        Debug.Log(index);
    }

    public void FightBoss(int selectedBoss)
    {
        PlayerPrefs.SetInt("selectedBoss", selectedBoss);
        Debug.Log(selectedBoss);
        SceneManager.LoadScene(4);
    }

    public void ReturnToMap()
    {
        //PlayerPrefs.SetInt("wasInCastle", 1);
        SceneManager.LoadScene(1);
    }
}
