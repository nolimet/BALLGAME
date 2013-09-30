using UnityEngine;
using System.Collections;

public class TextUpdate : MonoBehaviour {
	
	public GUIText TextGui;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		TextGui.text=("score: " +Global.Score +"\nHighScore: "+Global.TopScore);
	}
}
