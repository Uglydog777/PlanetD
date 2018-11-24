using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

   // bool isSpawnPlayer = true;
    [SerializeField] Vector3 planetPos;
    [SerializeField] float playerYOffset = 1.25f;
    [SerializeField] GameObject playerPreFab;


    // Use this for initialization
    void Start () {
        Vector3 planetPos = GameObject.Find("Planet").transform.position;
        SpawnPlayer();
    }

    private void SpawnPlayer()
    {
        Vector3 playerSpawnPos = new Vector3(planetPos.x, planetPos.y + playerYOffset, planetPos.z);
        Instantiate(playerPreFab, playerSpawnPos, playerPreFab.transform.rotation);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
