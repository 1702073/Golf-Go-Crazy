using UnityEngine;

[CreateAssetMenu(fileName = "waveData", menuName = "Scriptable Objects/waveData")]
public class waveData : ScriptableObject
{
    public GameObject enemyPrefab;
    public int enemyCount;
    public float enemySpacing;
    public float enemyRespawnTime;
    public float enemyHealth;
    public float currencyPerEnemy;
    public float enemySpeed;
}
