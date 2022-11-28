using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] EnemyWave enemyWave;
    [SerializeField] float enemyHordeDuration = 7f;
    [SerializeField] GameObject[] spawners;
    [SerializeField] ObjectPool[] objectPools;
    GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        enemyWave = FindObjectOfType<EnemyWave>();
        Debug.Log(spawners.Length);
        objectPools = FindObjectsOfType<ObjectPool>();
        foreach(ObjectPool objectPool in objectPools)
        {
            objectPool.StartSpawn();
        }
    }

    private void Update()
    {
        if(enemyWave.Slider.value == 10)
        {
            spawners[1].SetActive(true);
            StartCoroutine(SpawnHorde());
        }
        else if(enemyWave.Slider.value == 20)
        {
            spawners[2].SetActive(true);
            StartCoroutine(SpawnHorde());
        }
        else if (enemyWave.Slider.value == 100)
        {

        }
    }

    IEnumerator SpawnHorde()
    {
        objectPools = FindObjectsOfType<ObjectPool>();
        foreach (ObjectPool objectPool in objectPools)
        {
            objectPool.SetMinSpawnDelay(gameManager.HordeMinValueSpawn);
            objectPool.SetMaxSpawnDelay(gameManager.HordeMaxValueSpawn);
            objectPool.StopSpawn();
            objectPool.StartSpawn();
        }
        yield return new WaitForSeconds(enemyHordeDuration);
        foreach(ObjectPool objectPool in objectPools)
        {
            objectPool.SetMinSpawnDelay(gameManager.MinValueSpawn);
            objectPool.SetMaxSpawnDelay(gameManager.MaxValueSpawn);
            objectPool.StopSpawn();
            objectPool.StartSpawn();
        }
        StopCoroutine(SpawnHorde());
    }
}
