using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public string unitName;
    public int unitLevel;
    public int damage;
    public int maxHP;
    public int currentHP;
    public int sex;
    public int armorWeapon;

    public bool TakeDamage(int dmg)
    {
        currentHP -= dmg;

        if(currentHP <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool Heal()
    {
        //Debug.Log(Inventory.instance.items[0].title);
        int potion = 0;
        int i;

        if (Inventory.instance.items.Count == 0)
            return false;
        
        for ( i=0; i < Inventory.instance.items.Count; i++)
        {
            if (Inventory.instance.items[i].title == "Potion")
            {
                potion ++;
                break;
            }
        }

        if (potion > 0)
        {
            currentHP += Inventory.instance.items[i].value;
            if (currentHP >= maxHP)
            {
                currentHP = maxHP;

            }
            Inventory.instance.items.Remove(Inventory.instance.items[i]);
            return true;
        }
        else
        {
            return false;
        }
            


    }
}
