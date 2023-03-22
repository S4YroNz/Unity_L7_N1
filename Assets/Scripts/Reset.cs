using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    [SerializeField] private GameObject _piston;
    [SerializeField] private GameObject _gears;
    [SerializeField] private GameObject _fire;

    [SerializeField] private GameObject _pistonButton;
    [SerializeField] private GameObject _gearsButton;
    [SerializeField] private GameObject _fireButton;
    [SerializeField] private GameObject _prestigeButton;

    /*public void Start()
    {
        ResetAll();
        PlayerPrefs.SetInt("PrestigeLevel", 0);
    }*/
    public void ResetAll()
    {
       PlayerPrefs.SetInt("Money", 0);
        
       PlayerPrefs.SetFloat("ConveyorSpeed", 1f);  

       PlayerPrefs.SetFloat("SpawnerSpeed", 1f);

       PlayerPrefs.SetFloat("ClickMultiply", 1f);

       PlayerPrefs.SetInt("ClickMultiplyPrice", 10);

       PlayerPrefs.SetInt("ConveyorSpeedPrice", 10);

       PlayerPrefs.SetInt("SpawnerSpeedPrice", 10);

       PlayerPrefs.SetInt("Piston", 0);

       PlayerPrefs.SetInt("Gears", 0);

       PlayerPrefs.SetInt("Fire", 0);

    if (!PlayerPrefs.HasKey("PrestigeLevel"))
        {
            PlayerPrefs.SetInt("PrestigeLevel", 1);
        }
    else
        {
            PlayerPrefs.SetInt("PrestigeLevel", PlayerPrefs.GetInt("PrestigeLevel") + 1);
        }

    _piston.SetActive(false);
    _gears.SetActive(false);
    _fire.SetActive(false);

        
        _gearsButton.SetActive(false);
        _fireButton.SetActive(false);
        _prestigeButton.SetActive(false);   

    }
}
