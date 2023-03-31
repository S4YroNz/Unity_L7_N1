using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ClickOnChunk : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private GameObject _upgradeMenu;
    [SerializeField] private GameObject _tipsMenu;


    void Update()
    {
        if (_upgradeMenu.gameObject.activeSelf == true | _tipsMenu.gameObject.activeSelf == true)
        {
            return;
        }
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (hit.collider.TryGetComponent(out Chunk_lvl_1 chunk1))
                {
                    PlayerPrefs.SetInt("Money",Convert.ToInt32( PlayerPrefs.GetInt("Money") + chunk1._price * PlayerPrefs.GetFloat("ClickMultiply")));
                    Destroy(chunk1.gameObject);
                }
                if (hit.collider.TryGetComponent(out Chunk_lvl_2 chunk2))
                {
                    PlayerPrefs.SetInt("Money", Convert.ToInt32(PlayerPrefs.GetInt("Money") + chunk2._price * PlayerPrefs.GetFloat("ClickMultiply")));
                    Destroy(chunk2.gameObject);
                }
                if (hit.collider.TryGetComponent(out Chunk_lvl_3 chunk3))
                {
                    PlayerPrefs.SetInt("Money", Convert.ToInt32(PlayerPrefs.GetInt("Money") + chunk3._price * PlayerPrefs.GetFloat("ClickMultiply")));
                    Destroy(chunk3.gameObject);    
                }
                if (hit.collider.TryGetComponent(out Chunk_lvl_4 chunk4))
                {
                    PlayerPrefs.SetInt("Money", Convert.ToInt32(PlayerPrefs.GetInt("Money") + chunk4._price * PlayerPrefs.GetFloat("ClickMultiply")));
                    Destroy(chunk4.gameObject);
                }
            }
            
        }
    }
}
