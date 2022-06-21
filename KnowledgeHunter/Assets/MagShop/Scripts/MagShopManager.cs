using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MagShopManager : MonoBehaviour
{
    public int coins;
    public TMP_Text coinUI;
    public MagShopItemSO[] magShopItemsSo;    //collection of the items
    public MagShopTemplate[] magShopPanels;   //

    // Start is called before the first frame update
    void Start()
    {
        coinUI.text = "Coins: " + coins.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCoins()
    {
        coins++;
        coinUI.text = "Coins: " + coins.ToString();
        //CheckPurchaseable();
    }

    public void LoadPanels()
    {
        for(int i = 0; i < magShopItemsSo.Lenght; i++)
        {
            magShopPanels[i].titleTxt.text = magShopItemsSo[i].title;
            magShopPanels[i].descriptionTxt.text = magShopItemsSo[i].description;
            magShopPanels[i].costTxt.text = "Coins: " + magShopItemsSo[i].baseCost.ToString();
        }
    }



}
