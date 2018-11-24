//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour {
   // [SerializeField] GameObject asteroid;
    [SerializeField] GameObject planet;
    [SerializeField] float astroSpin = 300f;
    [SerializeField] float asteroidSpeed = 2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = Vector3.MoveTowards(transform.position, planet.transform.position, asteroidSpeed * Time.deltaTime); //alway moves towards the planet.
        transform.RotateAround(transform.position, Vector3.forward, astroSpin);
      //  RotateAstro();
	}



    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Astro collision HEH");
        Destroy(this.gameObject);
    }
}
