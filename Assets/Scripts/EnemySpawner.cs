using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnCoolDown = 3f;
    public int numberOfEnemies;
    private float lastSpawnTimeStamp = 0;


    void Start()
    {
        for (int i = 0; i < numberOfEnemies; i++)
        {
            SpawnEnemy();
        }
    }

    void Update()
    {
        if (Time.time >= lastSpawnTimeStamp + spawnCoolDown)
        {
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-19f, 19f), 0f, Random.Range(-19f, 19f));
        Quaternion spawnRotation = Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);
        GameObject enemy = (GameObject)Instantiate(enemyPrefab, spawnPosition, spawnRotation);
        lastSpawnTimeStamp = Time.time;
    }
}
