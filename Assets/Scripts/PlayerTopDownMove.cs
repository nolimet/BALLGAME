using UnityEngine;
using System.Collections;

public class PlayerTopDownMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0,Input.GetAxis("Horizontal")*2,0);
		rigidbody.AddRelativeForce(Input.GetAxis("Vertical")*10,0,0);
		
	}
	
	void OnCollisionEnter(Collision col)
	{
		if(col.collider.gameObject.name=="NorthWall")
		{
			transform.position=transform.position.x*-1;
		}
		if(col.collider.gameObject.name=="SouthWall")
		{
			transform.position=transform.position.x*-1;
		}
		if(col.collider.gameObject.name=="WestWall")
		{
			transform.position=transform.position.z*-1;
		}
		if(col.collider.gameObject.name=="EastWall")
		{
			transform.position=transform.position.z*-1;
		}
	}
}
