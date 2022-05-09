using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[System.Serializable]

public class MainMenu : MonoBehaviour
{

    public void sairJogo()
    {
        Debug.Log("SAIR");
        Application.Quit();
    }

}

