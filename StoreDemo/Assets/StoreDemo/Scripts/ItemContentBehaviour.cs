using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemContentBehaviour : MonoBehaviour
{
    [SerializeField] Image _itemIcon;
    [SerializeField] TMP_Text _itemName;

    public void ItemSetup(string name, Sprite icon)
    {
        _itemIcon.sprite = icon;
        _itemName.text = name;
    }
}
