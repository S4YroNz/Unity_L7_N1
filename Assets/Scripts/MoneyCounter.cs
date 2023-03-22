using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textMoney;
    [SerializeField] private TextMeshProUGUI _textPrestige;


    
    private void Update()
    {
       
            _textMoney.text = PlayerPrefs.GetInt("Money").ToString();
            _textPrestige.text = PlayerPrefs.GetInt("PrestigeLevel").ToString();
        
    }

 

}