﻿using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log (PlayerPrefsManager.GetDifficulty());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
