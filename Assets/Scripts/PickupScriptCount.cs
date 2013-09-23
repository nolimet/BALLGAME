using UnityEngine;
using System.Collections;

public class PickupScriptCount : MonoBehaviour {
	
	private int count;
	public GUIText countText;
	public GUIText gotAll;
	private int maxColl;
	
	void Start()
	{
		count=0;
		
		SetCountText();
		
		GameObject[] colle = GameObject.FindGameObjectsWithTag(Tags.collectible);
		maxColl = colle.Length;
		gotAll.gameObject.SetActive(false);
	}
	
		void OnTriggerEnter(Collider other)
	{
		Debug.Log ("Triggered");
		if (other.tag==Tags.collectible)
		{
			Debug.Log("hit pickup");
			
			other.gameObject.SetActive(false);
			count++;
			if(count>=maxColl)
			{
				gotAll.gameObject.SetActive(true);
				Debug.Log("win");
			}
			
			SetCountText();
			//Destroy(other.gameObject);
		}
	}
	void SetCountText()
	{
		countText.text = "Count: "+count;
	}
}
