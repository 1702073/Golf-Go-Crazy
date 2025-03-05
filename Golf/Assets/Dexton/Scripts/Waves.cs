using UnityEngine;

[CreateAssetMenu(fileName = "Waves", menuName = "Scriptable Objects/Waves")]
public class Waves : ScriptableObject
{
    public GameObject enemyPrefab;
    public int enemyCount;
    public float enemyScaling;
    public float enemyRespawnTime;
    public float enemyHealth;
    public int currencyPerEnemy;
    public float enemySpeed;
}
