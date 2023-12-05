using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviour : MonoBehaviour
{
    [SerializeField] Item item;

    void PickItem()
    {
        InventoryBehaviour.Instance.AddItem(item);
        Destroy(gameObject);
    }

    public string GetItemName()
    {
        return item.m_name;
    }
    public Sprite GetItemIcon()
    {
        return item.m_icon;
    }
}
