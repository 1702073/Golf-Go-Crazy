using System.Collections.Generic;
using UnityEngine;

public class WaveController : MonoBehaviour
{
    public Waves waveData;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < waveData.enemyCount; ++i)
        {
            Instantiate(waveData.enemyPrefab);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
