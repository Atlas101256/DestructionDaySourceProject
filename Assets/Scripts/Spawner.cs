using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject[] meteors;

    private float timeBtwSpawns;
    public float startTimeBtwSpawns;

    public float minTimeBtwSpawns;
    public float decrease;

    public GameObject player;
    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            if(timeBtwSpawns <= 0)
        {
            // Spawn Meteors
            Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
            GameObject randomMeteor = meteors[Random.Range(0, meteors.Length)];
            Instantiate(randomMeteor, randomSpawnPoint.position, Quaternion.identity);

            if(startTimeBtwSpawns > minTimeBtwSpawns)
            {
                startTimeBtwSpawns -= decrease;
            }
            timeBtwSpawns = startTimeBtwSpawns;

        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
        }
        
    }
}
