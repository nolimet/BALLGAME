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
		
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag=="Bullet")
		{
			if(Split==0)
			{
				for(int i=0;i<Mathf.Floor(Random.value*4)+1;i++)
				{
					Instantiate(Resources.Load("Bullet"), transform.localPosition,transform.rotation);
				}
			}
			else if (Split==1)
			{
				for(int i=0;i<Mathf.Floor(Random.value*4)+1;i++)
				{
					Instantiate(Resources.Load("Bullet"), transform.localPosition,transform.rotation);
				}
			}
			else if (Split==2)
			{
				for(int i=0;i<Mathf.Floor(Random.value*4)+1;i++)
				{
					Instantiate(Resources.Load("Bullet"), transform.localPosition,transform.rotation);
				}
			}
			Destroy(other.gameObject);
			Destroy(gameObject);
		}	
	}
}
