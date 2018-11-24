//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour {

    [SerializeField] float spawnTime = 5f;
    [SerializeField] float spawnTimeOffset = 0f;
    [SerializeField] GameObject asteroid;
    float nextSpawnTime = 0f;
    Vector3 asteroidStartPos;

    // Use this for initialization
    void Start()
    {
        nextSpawnTime = GetTime() + spawnTime + spawnTimeOffset;
    }
        


    // Update is called once per frame
    void Update()
    {
        if(GetTime() > nextSpawnTime)
        {
            SpawnAsteroid();
            nextSpawnTime = GetTime() + spawnTime;
        }
    }

    float GetTime()
    {
        float getTime;
        return getTime = Time.time;
    }

    private void SpawnAsteroid()
    {
        print("Spawning an asteriod");
        int screenSide = Random.Range(0, 3+1); // do this with enum later. 0 = left, 1 =right 2 = top 3 = bottem..
        float randomY = Random.Range(-5.00f, 5.00f);
        float randomX = Random.Range(-5.00f, 5.00f);

        switch (screenSide)
        {
            
            case 0:
                Vector3 asteroidStartPos = new Vector3(-8f, randomY, 0f);
                Instantiate(asteroid, asteroidStartPos, Quaternion.identity);
                break;
            case 1:
                asteroidStartPos = new Vector3(8f, randomY, 0f);
                Instantiate(asteroid, asteroidStartPos, Quaternion.identity);
                break;
            case 2:
                asteroidStartPos = new Vector3(randomX, 7.0f, 0f);
                Instantiate(asteroid, asteroidStartPos, Quaternion.identity);
                break;
            case 3:
                asteroidStartPos = new Vector3(randomX, -7.0f, 0f);
                Instantiate(asteroid, asteroidStartPos, Quaternion.identity);
                break;
            default:
                Debug.LogError("no screenSide found" + screenSide);
                break;
        }
    }
}
