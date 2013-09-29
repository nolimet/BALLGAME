using UnityEngine;
using System.Collections;

public class PlayerFire : MonoBehaviour {
	
	//public GameObject bullet;
	private int delay =0;
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetAxis("Fire1")>0&&delay==0)
		{
			//GameObject bul = 
			Instantiate(Resources.Load("Bullet"), transform.position,transform.rotation);
			//bul.name = "Bullet";
			delay=20;
		}
		if(delay>0)
		{
			delay--;	
		}
	}
}
