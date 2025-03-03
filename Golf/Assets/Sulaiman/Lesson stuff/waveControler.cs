using UnityEngine;

public class waveControler : MonoBehaviour
{
    public waveData waveData;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < waveData.enemyCount; i++)
        {
            Debug.Log(waveData.enemyCount);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
