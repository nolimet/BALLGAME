using UnityEngine;
using System.Collections;

public class NoWalls : MonoBehaviour {

void OnCollisionEnter(Collision col)
	{
		Vector3 newPos = new Vector3();
		
		newPos = transform.position;
		
		if(col.collider.gameObject.name=="NorthWall")
		{
			newPos.x=newPos.x*-1+1;
		}
		if(col.collider.gameObject.name=="SouthWall")
		{
			newPos.x=newPos.x*-1-1;
		}
		if(col.collider.gameObject.name=="WestWall")
		{
			newPos.z=newPos.z*-1+1;
		}
		if(col.collider.gameObject.name=="EastWall")
		{
			newPos.z=newPos.z*-1-1;
		}
		transform.position=newPos;
	}
}
