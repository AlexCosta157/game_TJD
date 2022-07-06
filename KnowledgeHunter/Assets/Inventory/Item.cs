using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : ScriptableObject
{
    // Start is called before the first frame update
    public string title;
    public string description;
    public int baseCost;
    public Sprite icon = null;
    public bool isDefaultItem = false;
}
