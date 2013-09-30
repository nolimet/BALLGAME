using UnityEngine;
using System.Collections;

public class PlayerFire : MonoBehaviour {
	
	private int delay =0;
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetAxis("Fire1")>0&&delay==0)
		{
			//GameObject bul = 
			Instantiate(Resources.Load("Bullet"), transform.localPosition,transform.rotation);
			//bul.name = "Bullet";
			Debug.Log ("pewpew");
			delay=20;
		}
		if(delay>0)
		{
			delay--;	
		}
	}
}
