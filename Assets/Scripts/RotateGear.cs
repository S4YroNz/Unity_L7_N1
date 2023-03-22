using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class RotateGear : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody _rb;
    private Transform _transform;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _transform = GetComponent<Transform>();
    }

   
    private void FixedUpdate()
    {
        _transform.Rotate(0, 0, _speed);
        
    }
}
