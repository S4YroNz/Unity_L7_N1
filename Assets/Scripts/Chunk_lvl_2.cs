using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Chunk_lvl_2 : MonoBehaviour
{
    private Chunks _chunks;
    private Rigidbody _rb;
    private Transform _transform;
    public int _price = 2;
    
    public void Init(Chunks chunks)
    {
        _chunks = chunks;
        _transform = GetComponent<Transform>();
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
        if (other.gameObject.tag == "Gears")
        {
            Chunk_lvl_3 NewChunk1 = Instantiate(_chunks.chunkLvl3, _transform.position, Quaternion.identity);
            Chunk_lvl_3 NewChunk2 = Instantiate(_chunks.chunkLvl3, _transform.position, Quaternion.identity);
            Chunk_lvl_3 NewChunk3 = Instantiate(_chunks.chunkLvl3, _transform.position, Quaternion.identity);
            NewChunk1.Init(_chunks);
            NewChunk2.Init(_chunks);
            NewChunk3.Init(_chunks);
            Destroy(gameObject);
        }
    }
}
