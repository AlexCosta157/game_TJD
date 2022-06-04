using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chest : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;

    public string InteractionPrompt => _prompt;

    public bool Interact(Interactor interactor){
        //throw new System.NotImplementedException();
        Debug.Log("opening Chest"); 
        SceneManager.LoadScene(2);
        return true;
    }
}
