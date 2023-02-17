using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoiSpawner : MonoBehaviour
{

    public GameObject[] daBoiPrefabs;
    public int daBoiIndex;
    public float spawnRangeX = 27;
    public float spawnPosZ;
    public float startDelay = 2f;
    public float spawnInterval = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomDaBoi", startDelay, spawnInterval);
    }

   void SpawnRandomDaBoi()
   {
        //Generate the x spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int daBoiIndex = Random.Range(0,daBoiPrefabs.Length);
        //spawn random Dabois on the X-Axis
        Instantiate(daBoiPrefabs[daBoiIndex], spawnPos, daBoiPrefabs[daBoiIndex].transform.rotation);

   }
}

