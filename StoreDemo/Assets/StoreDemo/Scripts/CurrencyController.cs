using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrencyController : MonoBehaviour
{
    [SerializeField] TMP_Text _currencyDisplayer;
    void Start()
    {
        DisplayCurrency();
    }

    public void DisplayCurrency()
    {
        _currencyDisplayer.text = "$" + Currency.CheckMoney();
    }
}
