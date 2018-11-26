using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distraction4 : MonoBehaviour {

    public int speed;
    int direction;//0 left 1 right
	// Use this for initialization
	void Start () {
        direction = 1;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.right);
        transform.Rotate(Vector3.up);
        if (transform.position.x <= -7)
            direction = 1;
        if (transform.position.x >= 7)
            direction = 0;
        if (direction == 1)
            transform.Translate(Vector3.right*Time.deltaTime*speed,Space.World);
        if (direction == 0)
            transform.Translate(Vector3.left*Time.deltaTime*speed,Space.World);
	}
}
