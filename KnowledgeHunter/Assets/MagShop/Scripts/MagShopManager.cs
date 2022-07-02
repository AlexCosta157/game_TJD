using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MagShopManager : MonoBehaviour
{
    public int coins;
    public TMP_Text coinUI;
    public MagShopItemSO[] magShopItemsSO;    //collection of the items
    public GameObject[] magShopPanelsGO;
    public MagShopTemplate[] magShopPanels;   //
    public Button[] myPurchaseBtns;

    // Start is called before the first frame update
    void Start()
    {   
        for(int i = 0; i < magShopItemsSO.Length; i++)
        {
            magShopPanelsGO[i].SetActive(true);
        }    
        coinUI.text = "Coins: " + coins.ToString();
        LoadPanels();
        CheckPurchaseable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCoins()
    {
        coins++;
        coinUI.text = "Coins: " + coins.ToString();
        CheckPurchaseable();
    }

    public void CheckPurchaseable()
    {
        for(int i = 0; i < magShopItemsSO.Length; i++)
        {
            if(coins >= magShopItemsSO[i].baseCost)
                myPurchaseBtns[i].interactable = true;
            else
                myPurchaseBtns[i].interactable = false;
        }
    }

    public void PurchaseItem(int btnNo)
    {
        if(coins >= magShopItemsSO[btnNo].baseCost)
        {
            coins = coins - magShopItemsSO[btnNo].baseCost;
            coinUI.text = "Coins: " + coins.ToString(); //sub coins
            CheckPurchaseable();    //refresh store
            //add item to inventory
            //Inventory.instance.Add(item)
        }
    }

    public void LoadPanels()
    {
        for(int i = 0; i < magShopItemsSO.Length; i++)
        {
            magShopPanels[i].titleTxt.text = magShopItemsSO[i].title;
            magShopPanels[i].descriptionTxt.text = magShopItemsSO[i].description;
            magShopPanels[i].costTxt.text = "Coins: " + magShopItemsSO[i].baseCost.ToString();
        }
    }




}
