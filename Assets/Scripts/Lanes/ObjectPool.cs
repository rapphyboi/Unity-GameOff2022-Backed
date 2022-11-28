using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] [Range(0, 50)] int poolSize = 5;

    [SerializeField] [Range(0.1f, 30f)] float minSpawnDelay = 1f;
    public float MinSpawnDelay { get { return minSpawnDelay; } }

    [SerializeField] [Range(0.1f, 30f)] float maxSpawnDelay = 10f;
    public float MaxSpawnDelay { get { return maxSpawnDelay; } }

    Coroutine spawnCoroutine = null;
    GameObject[] pool;
    void Awake()
    {
        PopulatePool();
    }

    void Start()
    {
        if (!enemyPrefab) { Debug.Log("Insert enemy!!!"); }
    }

    public void StartSpawn()
    {
        spawnCoroutine = StartCoroutine(SpawnEnemy());
    }
    public void StopSpawn()
    {
        if (spawnCoroutine != null)
        {
            StopCoroutine(spawnCoroutine);
        }
    }

    void PopulatePool()
    {
        pool = new GameObject[poolSize];

        for (int i = 0; i < pool.Length; i++)
        {
            pool[i] = Instantiate(enemyPrefab, transform);
            pool[i].SetActive(false);
            pool[i].GetComponent<EnemyDeath>().startPos = transform;
        }
    }

    void EnableObjectInPool()
    {
        for (int i = 0; i < pool.Length; i++)
        {
            if (!pool[i].activeInHierarchy)
            {
                pool[i].SetActive(true);
                return;
            }
        }
    }
    
    

    public void SetMinSpawnDelay(float delay)
    {
        minSpawnDelay = delay;
    }

    public void SetMaxSpawnDelay(float delay)
    {
        maxSpawnDelay = delay;
    }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            EnableObjectInPool();
        }
    }
}
