using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BossSelection : MonoBehaviour
{
    public int selectedBoss = 0;

    public void SelectBoss(int index)
    {
        Debug.Log(index);
    }

    public void FightBoss()
    {
        PlayerPrefs.SetInt("selectedBoss", selectedBoss);
        SceneManager.LoadScene(4);
    }

    public void ReturnToMap()
    {
        //PlayerPrefs.SetInt("wasInCastle", 1);
        SceneManager.LoadScene(1);
    }
}
