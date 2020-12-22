﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEntrance : MonoBehaviour {

	public string transitionName;

	// Use this for initialization
	void Start () {
		if (transitionName == PlayerContoller.instance.areaTransitionName) 
		{
			PlayerContoller.instance.transform.position = transform.position;    
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
