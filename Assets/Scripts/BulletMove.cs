using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour {

	public float Force = 40;
	public float maxSpeed = 5;
	public int lifeTime=180;
	
	// Update is called once per frame
	void Startup () {
		//transform.localPosition += new Vector3 (0,0,1);
		//0//ime=60*lifeTime;
	}
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
		if(lifeTime>0)
		{
			lifeTime--;
		}
		else
		{
			Destroy(this.gameObject);	
		}
	}
}
