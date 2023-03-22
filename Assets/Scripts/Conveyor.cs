using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class Conveyor : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _speed;

    private void FixedUpdate()
    {
        
        Vector3 lastPos = _rb.position;
        _rb.position += Vector3.left * _speed * Time.fixedDeltaTime * PlayerPrefs.GetFloat("ConveyorSpeed") * (PlayerPrefs.GetInt("PrestigeLevel") + 1);
        _rb.MovePosition(lastPos);
    }
}
