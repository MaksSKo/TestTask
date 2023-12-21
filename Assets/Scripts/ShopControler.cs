using System.Collections.Generic;
using UnityEngine;

public class ShopControler : MonoBehaviour
{
    [SerializeField] private GameObject errorView;
    [SerializeField] private GameObject successView;
    [SerializeField] private List<ShopItem> items;

    public void Start()
    {
        items.ForEach(item => 
        {
            item.Initialize();
        });
    }

    public void BuyTickets(int amount)
    {
        Global.Currency += amount;
        successView.SetActive(true);
    }
}
