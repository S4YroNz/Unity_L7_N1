using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk_lvl_4 : MonoBehaviour
{
    private Rigidbody _rb;
    public int _price = 4;
    public void Init(Chunks chunks)
    {
        _rb = GetComponent<Rigidbody>();
        _rb.constraints = RigidbodyConstraints.FreezePositionZ;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hopper")
        {
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + _price);
            Destroy(gameObject);
        }

    }
}
