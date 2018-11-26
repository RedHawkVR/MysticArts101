using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distraction3Behaviour : MonoBehaviour {

    int direction;//0 forward 1 back
	// Use this for initialization
	void Start () {
        direction = 1;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.z >= 6)
            direction = 1;
        if (transform.position.z <= -6)
            direction = 0;
        if (direction == 0)
            transform.Translate(Vector3.forward*Time.deltaTime,Space.World);
        if (direction == 1)
            transform.Translate(Vector3.back*Time.deltaTime,Space.World);
	}
}
