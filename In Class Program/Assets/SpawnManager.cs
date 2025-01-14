using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] oppPrefabs;
    public float spawnRangeX = 0;
    public float spawnPosZ = 0;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomOpp", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomOpp()
    {
        int oppIndex = Random.Range(0, oppPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(oppPrefabs[oppIndex], spawnPos,
            oppPrefabs[oppIndex].transform.rotation);
    }
}
