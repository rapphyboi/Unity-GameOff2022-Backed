using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Currency : MonoBehaviour
{
    [SerializeField] int startCurrency = 0;
    [SerializeField] int currentCurrency;
    TextMeshProUGUI currencyText;

    private void Start()
    {
        currencyText = GetComponent<TextMeshProUGUI>();
        currentCurrency = startCurrency;
        UpdateCurrencyDisplay();
    }

    void UpdateCurrencyDisplay()
    {
        currencyText.text = currentCurrency.ToString();
    }

    public void AddCurrency()
    {
        currentCurrency++;
        UpdateCurrencyDisplay();
    }
}
