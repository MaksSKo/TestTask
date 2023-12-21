using System;
using UnityEngine;

public class ShopItem : MonoBehaviour
{
    [SerializeField] private int itemId;
    [SerializeField] private string itemType;
    [SerializeField] private int levelToUnlock;
    [SerializeField] private int price;
    [SerializeField] private GameObject checkmark;
    [SerializeField] private GameObject priceText;
    private bool isAvailable;
    private bool isBought;


    public void Initialize()
    {
        isBought = PlayerPrefs.GetInt($"ItemBought{itemId}{itemType}", 0) == 1 ? true : false;
        if (Global.LastAvailableLevel > levelToUnlock)
        {
            PlayerPrefs.SetInt($"ItemAvailable{itemId}{itemType}", 1);
        }

        isAvailable = PlayerPrefs.GetInt($"ItemAvailable{itemId}{itemType}", 0) == 1 ? true : false;

        if (itemId == 1)
        {
            isBought = true;
        }

        if (isBought)
        {
            Indicate();
        }
    }

    public void TryBuyItem()
    {
        if (isBought || !isAvailable)
        {
            return;
        }

        if (Global.Currency < price)
        {
            return;
        }

        Global.Currency -= price;
        isBought = true;
        Indicate();
        PlayerPrefs.SetInt($"ItemBought{itemId}{itemType}", 1);
    }

    private void Indicate()
    {
        priceText.SetActive(false);
        checkmark.SetActive(true);
    }
} 
