using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] planePrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 6.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPlanes", startDelay, spawnInterval); 
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRandomPlane()
    {
        int planeIndex = Random.Range(0, planePrefabs.Length); 
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            Instantiate(planePrefabs[planeIndex], spawnPos,
            planePrefabs[planeIndex].transform.rotation);
        }
    }
}
