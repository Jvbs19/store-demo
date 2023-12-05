using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopBehaviour : MonoBehaviour
{
    [SerializeField] GameObject _shopUI;
    [SerializeField] List<Item> _shopItems = new List<Item>();
    [SerializeField] Transform _itensContent;
    [SerializeField] GameObject _intentoryItem;

    public void OnOffShop()
    {
        bool enable = _shopUI.activeSelf ? false : true;
        _shopUI.SetActive(enable);

        if (enable)
            DisplayShopItems();
    }
    public void AddItem(Item item)
    {
        _shopItems.Add(item);
    }
    public void RemoveItem(Item item)
    {
        _shopItems.Remove(item);
    }
    public void DisplayShopItems()
    {
        foreach (Transform item in _itensContent)
        {
            Destroy(item.gameObject);
        }
        foreach (var item in _shopItems)
        {
            GameObject obj = Instantiate(_intentoryItem, _itensContent);

            ItemContentBehaviour itn = obj.GetComponent<ItemContentBehaviour>();
            itn.ItemSetup(item.m_name, item.m_icon);
        }
    }
    public void BuyItem(Item item)
    {
        if (item.m_price > Currency.CheckMoney())
            return;

        Currency.CalculateMoney(-item.m_price);
        InventoryBehaviour.Instance.AddItem(item);
        RemoveItem(item);
    }
    public void SellItem(Item item)
    {
        Currency.CalculateMoney(+item.m_price);
        AddItem(item);
        InventoryBehaviour.Instance.RemoveItem(item);
    }
}
