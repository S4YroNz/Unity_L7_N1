using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Chunk_lvl_1 : MonoBehaviour
{
    private Chunks _chunks;
    private Transform _transform;
    private Rigidbody _rb;
    public int _price = 1;

    public void Init(Chunks chunks)
    {
        _chunks = chunks;
        _transform = GetComponent<Transform>();
        _rb = GetComponent<Rigidbody>();
        _rb.constraints = RigidbodyConstraints.FreezePositionZ;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Piston")
        { 
            
           Chunk_lvl_2 NewChunk1 = Instantiate(_chunks.chunkLvl2, _transform.position, Quaternion.identity);
           Chunk_lvl_2 NewChunk2 = Instantiate(_chunks.chunkLvl2, _transform.position, Quaternion.identity);
            NewChunk1.Init(_chunks);
            NewChunk2.Init(_chunks);
           Destroy(gameObject);
        }
        if (other.gameObject.tag == "Hopper")
        {
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + _price);
            Destroy(gameObject);
        }
    }
}
