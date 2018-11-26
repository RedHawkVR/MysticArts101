using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour {

    public GameObject sound1;
    public GameObject sound2;
    public GameObject sound3;
    public GameObject sound4;
    public GameObject goal;
    public float time;

    void Start()
    {
        time = 0;
    }
	void Update () {
        time+=Time.deltaTime;
        if(goal.GetComponent<GoalBehaviour>().complete==false)
        if (time % 10 >= 0 && time % 10 <.05)
        {
                sound1.GetComponent<AudioSource>().Stop();
                sound2.GetComponent<AudioSource>().Stop();
                sound3.GetComponent<AudioSource>().Stop();
                sound4.GetComponent<AudioSource>().Stop();
            int pick = (Random.Range(0,20) % 9);
            if (pick == 0)
            {
                sound1.GetComponent<AudioSource>().Play(0);

            }
            else if(pick==1)
            {
                sound2.GetComponent<AudioSource>().Play(0);
            }
            else if(pick==2)
            {
                sound3.GetComponent<AudioSource>().Play(0);
            }
            else if(pick==3)
            {
                sound4.GetComponent<AudioSource>().Play(0);
            }
            else if(pick==4)
                {
                    sound1.GetComponent<AudioSource>().Play(0);
                    sound2.GetComponent<AudioSource>().Play(0);
                }
            else if(pick==5)
                {
                    sound2.GetComponent<AudioSource>().Play(0);
                    sound3.GetComponent<AudioSource>().Play(0);
                }
            else if(pick==6)
                {
                    sound3.GetComponent<AudioSource>().Play(0);
                    sound4.GetComponent<AudioSource>().Play(0);
                }
            else if(pick==7)
                {
                    sound4.GetComponent<AudioSource>().Play(0);
                    sound2.GetComponent<AudioSource>().Play(0);
                }
            else if(pick==8)
                {
                    sound1.GetComponent<AudioSource>().Play(0);
                    sound3.GetComponent<AudioSource>().Play(0);
                }
 
            }
	}
}
