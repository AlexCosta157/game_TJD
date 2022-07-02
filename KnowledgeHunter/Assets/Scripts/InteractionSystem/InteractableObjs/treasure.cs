using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treasure : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;

    public string InteractionPrompt => _prompt;

    public bool Interact(Interactor interactor){
       
        var inventory = interactor.GetComponent<Inventory_test>();

        if(inventory == null) return false;

        if(inventory.HasKey){
            Debug.Log("opening treasure");
            return true;
        } 

        Debug.Log("No key found!");
        return false;
    }
}

