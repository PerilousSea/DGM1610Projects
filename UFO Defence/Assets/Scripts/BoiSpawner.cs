using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoiSpawner : MonoBehaviour
{

    public GameObject[] daBoi;
    public int daBoiIndex;
    public float xSpawnRange = 27;
    public float ySpawnPos;
    public float startDelay = 0.5f;
    public float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomDaBoi", startDelay, spawnInterval);
    }

   void SpawnRandomDaBoi()
   {
        //Generate the x spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-xSpawnRange, xSpawnRange), ySpawnPos, 0);

        //spawn random Dabois on the X-Axis
        Instantiate(daBoi[daBoiIndex], spawnPos, daBoi[daBoiIndex].transform.rotation);

   }
}

