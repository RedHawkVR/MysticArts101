using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

	public Scene nextScene;

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Ball"))
		{
			if (nextScene.IsValid())
			{
				SceneManager.LoadScene(nextScene.name);
			}
		}
	}

}
