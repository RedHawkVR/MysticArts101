﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

	//public Scene nextScene;
	public string sceneName;
	
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Ball"))
		{
			if (SceneManager.GetSceneByName(sceneName).IsValid())
			{
				SceneManager.LoadScene(sceneName);
			}
			else
			{
				Debug.Log("Scene: " + sceneName + " not found!");
			}
		}
	}

}
