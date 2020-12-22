using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CameraController : MonoBehaviour {

	public Transform target;

	public Tilemap theMap;
	private Vector3 bottomLeftLimit;
	private Vector3 topRightLimit;

	private float halfHeight;
	private float halfWidh;

	// Use this for initialization
	void Start () {

		target = PlayerContoller.instance.transform;


		halfHeight = Camera.main.orthographicSize;
		halfWidh = halfHeight * Camera.main.aspect;

		bottomLeftLimit = theMap.localBounds.min + new Vector3(halfWidh, halfHeight, 0f); 
		topRightLimit = theMap.localBounds.max + new Vector3(-halfHeight, -halfWidh, 0f);

		PlayerContoller.instance.SetBounds(theMap.localBounds.min, theMap.localBounds.max);
	}
	
	// LateUpdate is called once per frame after update
	void LateUpdate () {
		transform.position = new Vector3 (target.position.x, target.position.y, transform.position.z);

		//keep the camera inside the bounds
		transform.position = new Vector3(Mathf.Clamp(transform.position.x, bottomLeftLimit.x, topRightLimit.x), Mathf.Clamp(transform.position.y, bottomLeftLimit.y, topRightLimit.y), transform.position.z); 
	}
}
	