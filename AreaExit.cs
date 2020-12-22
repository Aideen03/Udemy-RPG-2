using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaExit : MonoBehaviour {

	public string areaToLoad;

	public string areaTransitionName;

	public AreaEntrance theEntrance;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		theEntrance.transitionName = areaTransitionName;
		 
	}

	private void OnTriggerEnter2D(Collider2D other) 
	{
		if(other.tag == "Player") 
		{
			SceneManager.LoadScene(areaToLoad); 

			PlayerContoller.instance.areaTransitionName = areaTransitionName;
		}
	}
}
