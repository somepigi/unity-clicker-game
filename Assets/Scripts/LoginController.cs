﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void MoveGame(){


		SceneManager.LoadScene ("Game");



	}
	public void MoveLogin(){


		SceneManager.LoadScene ("Login");



	}
}
