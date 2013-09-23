using UnityEngine;
using System.Collections;

public class PlayerTopDownMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.AddTorque(0,Input.GetAxis("Horizontal"),0);
		rigidbody.AddForce(Input.GetAxis("Vertical"),0,0);
		
	}
}
