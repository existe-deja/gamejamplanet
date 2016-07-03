﻿using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {
	public GameObject Camera_Target;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (Camera_Target.transform);
		transform.RotateAround (Camera_Target.transform.position,Vector3.up, 1F);
	}
}
