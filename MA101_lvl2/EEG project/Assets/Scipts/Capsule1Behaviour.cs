using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule1Behaviour : MonoBehaviour {


	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up * Time.deltaTime * 100);
        transform.Rotate(Vector3.right * Time.deltaTime * 100);
    }
}
