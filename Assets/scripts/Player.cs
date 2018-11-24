using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

   // public GameObject playerPreFab;

    [SerializeField] Vector3 planetPos;
    [SerializeField] float playerSpeed = 5f;
   // [SerializeField] float playerYOffset = 1f;

    // Use this for initialization
    void Start ()
    {
        Vector3 planetPos = GameObject.Find("Planet").transform.position;
        //PlayerStartPosition();
    }


    // Update is called once per frame
    void Update () {
      
        PlayerMovement();
	}

    private void PlayerMovement()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(planetPos, Vector3.forward, playerSpeed * Time.deltaTime);
        
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(planetPos, Vector3.forward, -playerSpeed * Time.deltaTime);
        }
    }

    private void PlayerStartPosition()
    {
         
      //  Vector3 playerStartPos = new Vector3(planetPos.x, planetPos.y + playerYOffset, planetPos.z);
        // place player relative to the planet
        // transform.position = playerStartPos; // keep this line here up works with player in screen
        //Instantiate(playerPreFab, playerStartPos, playerPreFab.transform.rotation);
    }
}
