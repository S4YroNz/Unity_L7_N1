using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _convSpeed;
    [SerializeField] private TextMeshProUGUI _clickMult;
    [SerializeField] private TextMeshProUGUI _spawnSpeed;

    [SerializeField] private TextMeshProUGUI _convSpeedPrice;
    [SerializeField] private TextMeshProUGUI _clickMultPrice;
    [SerializeField] private TextMeshProUGUI _spawnSpeedPrice;

    [SerializeField] private TextMeshProUGUI _pistonPrice;
    [SerializeField] private TextMeshProUGUI _gearsPrice;
    [SerializeField] private TextMeshProUGUI _firePrice;

    [SerializeField] private GameObject _gearsButton;
    [SerializeField] private GameObject _fireButton;
    [SerializeField] private GameObject _prestigeButton;

    [SerializeField] private GameObject _piston;
    [SerializeField] private GameObject _gears;
    [SerializeField] private GameObject _fire;



    void Start()
    {
        if (!PlayerPrefs.HasKey("Money"))
        {
            PlayerPrefs.SetInt("Money", 0);
        }

        if (!PlayerPrefs.HasKey("ConveyorSpeed"))
        {
            PlayerPrefs.SetFloat("ConveyorSpeed", 1f);
        }
        if (!PlayerPrefs.HasKey("SpawnerSpeed"))
        {
            PlayerPrefs.SetFloat("SpawnerSpeed", 1f);
        }
        if (!PlayerPrefs.HasKey("ClickMultiply"))
        {
            PlayerPrefs.SetFloat("ClickMultiply", 1f);
        }

        if (!PlayerPrefs.HasKey("ClickMultiplyPrice"))
        {
            PlayerPrefs.SetInt("ClickMultiplyPrice", 10);
        }
        if (!PlayerPrefs.HasKey("ConveyorSpeedPrice"))
        {
            PlayerPrefs.SetInt("ConveyorSpeedPrice", 10);
        }
        if (!PlayerPrefs.HasKey("SpawnerSpeedPrice"))
        {
            PlayerPrefs.SetInt("SpawnerSpeedPrice", 10);
        }

        if (!PlayerPrefs.HasKey("Piston"))
        {
            PlayerPrefs.SetInt("Piston", 0);
        }
        if (!PlayerPrefs.HasKey("Gears"))
        {
            PlayerPrefs.SetInt("Gears", 0);
        }
        if (!PlayerPrefs.HasKey("Fire"))
        {
            PlayerPrefs.SetInt("Fire", 0);
        }

    }

    
    void Update()
    {
        _convSpeed.text = "Conveyor speed\r\nCurrent: " + PlayerPrefs.GetFloat("ConveyorSpeed").ToString() + "x";
        _spawnSpeed.text = "Spawner speed\r\nCurrent: " + PlayerPrefs.GetFloat("SpawnerSpeed").ToString() + "x";
        _clickMult.text = "Click multiply\r\nCurrent: " + PlayerPrefs.GetFloat("ClickMultiply").ToString() + "x";

        _convSpeedPrice.text = PlayerPrefs.GetInt("ConveyorSpeedPrice").ToString() + "$";
        _spawnSpeedPrice.text = PlayerPrefs.GetInt("SpawnerSpeedPrice").ToString() + "$";
        _clickMultPrice.text = PlayerPrefs.GetInt("ClickMultiplyPrice").ToString() + "$";
        if (PlayerPrefs.GetInt("Piston") == 0)
        {
            _pistonPrice.text = "100$";
        }
        else
        {
            _pistonPrice.text = "Owned";
        }
        if (PlayerPrefs.GetInt("Gears") == 0)
        {
            _gearsPrice.text = "500$";
        }
        else
        {
            _gearsPrice.text = "Owned";
        }
        if (PlayerPrefs.GetInt("Fire") == 0)
        {
            _firePrice.text = "1000$";
        }
        else
        {
            _firePrice.text = "Owned";
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + 1000);
        }

    }

    public void ConveyorUpgrade()
    {
        if (PlayerPrefs.GetInt("Money") >= PlayerPrefs.GetInt("ConveyorSpeedPrice"))
            { 
        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - PlayerPrefs.GetInt("ConveyorSpeedPrice"));
        PlayerPrefs.SetFloat("ConveyorSpeed", PlayerPrefs.GetFloat("ConveyorSpeed") + 0.1f);
        PlayerPrefs.SetInt("ConveyorSpeedPrice",Convert.ToInt32(Convert.ToDouble(PlayerPrefs.GetInt("ConveyorSpeedPrice")) * 1.5));
        }

    }

    public void ClickMultiplyUpgrade()
    {
        if (PlayerPrefs.GetInt("Money") >= PlayerPrefs.GetInt("ClickMultiplyPrice")) { 
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - PlayerPrefs.GetInt("ClickMultiplyPrice"));
        PlayerPrefs.SetFloat("ClickMultiply", PlayerPrefs.GetFloat("ClickMultiply") + 0.1f);
        PlayerPrefs.SetInt("ClickMultiplyPrice", Convert.ToInt32(Convert.ToDouble(PlayerPrefs.GetInt("ClickMultiplyPrice")) * 1.5));
        }

    }

    public void SpawnerSpeedUpgrade()
    {
        if (PlayerPrefs.GetInt("Money") >= PlayerPrefs.GetInt("SpawnerSpeedPrice"))
        {
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - PlayerPrefs.GetInt("SpawnerSpeedPrice"));
            PlayerPrefs.SetFloat("SpawnerSpeed", PlayerPrefs.GetFloat("SpawnerSpeed") + 0.1f);
            PlayerPrefs.SetInt("SpawnerSpeedPrice", Convert.ToInt32(Convert.ToDouble(PlayerPrefs.GetInt("SpawnerSpeedPrice")) * 1.5));
        }
    }

    public void PistonUpgrade()
    {
        if (PlayerPrefs.GetInt("Money") >= 100 && PlayerPrefs.GetInt("Piston") == 0)
        {
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 100);
            PlayerPrefs.SetInt("Piston", 1);
            _gearsButton.SetActive(true);
            _piston.SetActive(true);
            
        }
    }

    public void GearsUpgrade()
    {
        if (PlayerPrefs.GetInt("Money") >= 500 && PlayerPrefs.GetInt("Gears") == 0)
        {
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 500);
            PlayerPrefs.SetInt("Gears", 1);
            _fireButton.SetActive(true);
            _gears.SetActive(true);

        }
    }

    public void FireUpgrade()
    {
        if (PlayerPrefs.GetInt("Money") >= 1000 && PlayerPrefs.GetInt("Fire") == 0)
        {
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 1000);
            PlayerPrefs.SetInt("Fire", 1);
            _prestigeButton.SetActive(true);
            _fire.SetActive(true);
        }
    }
}
