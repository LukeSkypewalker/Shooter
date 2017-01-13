﻿using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemyPrefab;
    public int numberOfEnemies; 

    void Start()
    {
        for (int i = 0; i < numberOfEnemies; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-8f, 8f), 0f, Random.Range(-8f, 8f));
            Quaternion spawnRotation = Quaternion.Euler(0f, Random.Range(0f,180f), 0f);
            GameObject enemy = (GameObject) Instantiate(enemyPrefab, spawnPosition, spawnRotation);      
        }
    }
}
