using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetOrbit : MonoBehaviour {

    public GameObject star;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(star.transform.position, Vector3.up, 90 * Time.deltaTime);
        transform.Rotate(Vector3.up * 90 * Time.deltaTime);
    }
}
