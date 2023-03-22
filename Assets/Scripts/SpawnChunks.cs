using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnChunks : MonoBehaviour
{
    
    [SerializeField] private Chunks _chunks;
    [SerializeField] private float _period = 1f;

    private float _nextActionTime = 0.0f;
    private Transform _tranform;
    
   private void Start()
    {
        _tranform= GetComponent<Transform>();
    }

    private void Update()
    {
        if (Time.time > _nextActionTime)
        {
            _nextActionTime += _period / PlayerPrefs.GetFloat("SpawnerSpeed");
            Chunk_lvl_1 NewChunk = Instantiate(_chunks.chunkLvl1, _tranform.position, Quaternion.identity);
            NewChunk.Init(_chunks);
        }
    }
}
