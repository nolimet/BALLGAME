using UnityEngine;
using System.Collections;

public class Asttroriod : MonoBehaviour {
	
	private float ranrot;
	public float Force = 40;
	public float maxSpeed = 5;
	private int interVal = 360;
	public int Split=0;
	void Start()
		{
			transform.Rotate(0,Random.value*360,0);
		}	
	void Update () {
		if(interVal==0)
		{
			interVal=360;
			transform.Rotate(0,Random.value*25,0);
		}
		interVal--;
			
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
	
	void OnCollisionEnter(Collision col)
	{
		if(col.collider.gameObject.name=="Bullet")
		{
			Destroy(col.collider.gameObject);
			for(int i=0;i<Mathf.Floor(Random.value*4);i++)
			{
				Instantiate(
			}
		}
	}
}
