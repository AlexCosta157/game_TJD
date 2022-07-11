using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "shopMenu", menuName = "Scriptable Objects/New Shop Item", order = 1)]
public class Item : ScriptableObject
{
    // Start is called before the first frame update
    public string title;
    public string description;
    public int baseCost;
    public Sprite icon = null;
    public bool isDefaultItem = false;
    public int armour_type;
    public bool showInInventory = true;
    public int value;

    // Called when the item is pressed in the inventory
	public virtual void Use ()
	{
        if(this.isDefaultItem == true)
        {
            PlayerPrefs.SetInt("armorLevel", armour_type);
            if(SceneManager.GetActiveScene().buildIndex == 1)
            {
                SceneManager.LoadScene(1);
            }
            Debug.Log("KUnami");
        }
		// Use the item
		// Something may happen
	}

}
