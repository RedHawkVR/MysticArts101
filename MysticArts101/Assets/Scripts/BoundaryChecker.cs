using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryChecker : MonoBehaviour {

	public Transform boundaryTop;
	public Transform boundaryRight;
	public Transform boundaryBottom;
	public Transform boundaryLeft;

	private float top, right, bottom, left;

	private Vector3 startPos;
	private Vector3 currentPos;

	// Use this for initialization
	void Start () {
		startPos = this.transform.position;
		top = boundaryTop.position.z;
		bottom = boundaryBottom.position.z;
		right = boundaryRight.position.x;
		left = boundaryLeft.position.x;
		Debug.Log(
			"start x: " + startPos.x + " start z: " + startPos.z +
			"\ntop: " + top + " bot: " + bottom +
			" left: " + left + " right: " + right
		);
	}
	
	// LateUpdate is called once per frame after Update
	void LateUpdate () {
		currentPos = this.transform.position;
		if ((currentPos.x > right) || (currentPos.x < left) ||
			(currentPos.z > top) || (currentPos.z < bottom))
		{
			this.transform.position = startPos;
		}
	}

}
