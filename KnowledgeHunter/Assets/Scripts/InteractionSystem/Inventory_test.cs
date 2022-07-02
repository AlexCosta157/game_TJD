using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_test : MonoBehaviour
{
    public bool HasKey = false;

    private void Update(){
        if(Input.GetKeyDown("k"))
            HasKey = !HasKey;
    }
}
