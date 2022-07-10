using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{

    #region Singleton

    public static InventoryUI instance1;

    void Awake()
    {
        if (instance1 != null)
        {
            Debug.LogWarning("More than one instance of inventory found!");
            return;
        }
        else
        {
            instance1 = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    #endregion


    public Transform itemsParent;
    public GameObject inventoryUI;

    Inventory inventory;

    InventorySlot[] slots;
    public TMP_Text coinUI;
    
    // Start is called before the first frame update
    void Start()
    {
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += UpdateUI;
        coinUI.text = "Coins: " + Inventory.instance.money.ToString();
        inventoryUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            inventoryUI.SetActive(!inventoryUI.activeSelf);
            UpdateUI();
        }
    }

    void UpdateUI()
    {
        InventorySlot[] slots = GetComponentsInChildren<InventorySlot>();
        coinUI.text = "Coins: " + Inventory.instance.money.ToString();

        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }
}