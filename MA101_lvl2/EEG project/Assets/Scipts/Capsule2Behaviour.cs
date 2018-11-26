using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule2Behaviour : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.down * Time.deltaTime * 100);
        transform.Rotate(Vector3.left * Time.deltaTime * 100);
    }
}
