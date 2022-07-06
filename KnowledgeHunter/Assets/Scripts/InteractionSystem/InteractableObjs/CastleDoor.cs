using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CastleDoor : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;

    public string InteractionPrompt => _prompt;

    public bool Interact(Interactor interactor){
        //throw new System.NotImplementedException();
        Debug.Log("opening Castle Door");
        SceneManager.LoadScene(2);
        return true;
    }
}