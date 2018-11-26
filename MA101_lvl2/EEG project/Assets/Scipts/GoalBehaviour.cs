using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBehaviour : MonoBehaviour {

    public GameObject player;
    public bool complete;

    void Start()
    {
        complete = false;
    }
	// Update is called once per frame
	void OnCollisionEnter(Collision blah)
    {
        if (blah.gameObject.tag == "Ball")
        {
            complete = true;
        }
    }
}
