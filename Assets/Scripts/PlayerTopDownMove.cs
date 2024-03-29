﻿using UnityEngine;
using System.Collections;

public class PlayerTopDownMove : MonoBehaviour {
	// Use this for initialization

	public float maxSpeed = 20;
	public float Force = 40;
	// Update is called once per frame
	void Update () {
		Vector3 tempVel = rigidbody.velocity;
		if(tempVel.z>maxSpeed)
		{
			tempVel.z=maxSpeed;
		}
		if(tempVel.x>maxSpeed)
		{
			tempVel.x=maxSpeed;
		}
		if(tempVel.z<-maxSpeed)
		{
			tempVel.z=-maxSpeed;
		}
		if(tempVel.x<-maxSpeed)
		{
			tempVel.x=-maxSpeed;
		}
		rigidbody.velocity=tempVel;
		
		transform.Rotate(0,Input.GetAxis("Horizontal")*2,0);
		rigidbody.AddRelativeForce(Input.GetAxis("Vertical")*Force,0,0);
		
	}
}
