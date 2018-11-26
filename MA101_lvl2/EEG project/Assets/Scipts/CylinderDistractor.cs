using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderDistractor : MonoBehaviour {

    public GameObject goal;
    int direction;//0 is down 1 is up
    // Use this for initialization
	void Start () {
        direction = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(goal.GetComponent<GoalBehaviour>().complete==false)
        {
            transform.Rotate(Vector3.left * Time.deltaTime*100);
            if (transform.position.y <= 1)
                direction = 1;
            else if (transform.position.y >= 10)
                direction = 0;
            if(direction==0)
                transform.Translate(Vector3.down * Time.deltaTime, Space.World);
            else if(direction==1)
                transform.Translate(Vector3.up*Time.deltaTime,Space.World);
        }
	}
}
