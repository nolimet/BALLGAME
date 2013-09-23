using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	
	public float speed = 2000;
	public float rotspeed =1.5f;
	//private bool groundhit=true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//rigidbody.velocity = Vector3.zero;
		//rigidbody.AddForce(speed*Input.GetAxis("Horizontal"),0,speed*Input.GetAxis("Vertical"));
		//transform.Rotate(0,1.5f*Input.GetAxis("Horizontal"),0);
		
		float hormove = Input.GetAxis("Horizontal");
		float vermove = Input.GetAxis("Vertical");
		float jump = 0;
		if(transform.position.y	<0.6f && Input.GetAxis("Jump")>0.0f) //transform.position.y	<0.6f
		{
			jump = 1000;
			Debug.Log ("jumped");
		}
		Vector3 move = new Vector3(hormove*speed,jump,vermove*speed);
		
		
		rigidbody.AddForce(move * Time.deltaTime);
	
	}
	
	void OnCollisionEnter(Collision col)
	{
		
	}
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag=="SlowField")
		{
			speed= 500;
			Debug.Log("slowfield");
		}
		else
		{	
			speed =2000;
		}
		
	}

	
}
