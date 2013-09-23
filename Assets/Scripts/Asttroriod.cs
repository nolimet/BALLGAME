using UnityEngine;
using System.Collections;

public class Asttroriod : MonoBehaviour {
	
	private float ranrot;
	public float Force = 40;
	public float maxSpeed = 5;
	// Use this for initialization
	void Start () {
		transform.Rotate(0,Random.value*360,0);
	}
	
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
		
		rigidbody.AddRelativeForce(Force,0,0);
	}
}
