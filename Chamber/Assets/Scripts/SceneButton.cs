﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButton : MonoBehaviour
{
	[SerializeField] private int sceneNumber = 0;

	void OnMouseUp()
	{
		SceneManager.LoadScene(sceneNumber); // load game scene
	}
}
