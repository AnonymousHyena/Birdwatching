using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunMovement : MonoBehaviour {

    public GameObject directionalLight;
	
	// Update is called once per frame
	void Update () {
        directionalLight.transform.Rotate(0, Time.deltaTime, 0);
	}
}
