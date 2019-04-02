using UnityEngine;
using System.Collections;

public class levelselect : MonoBehaviour {
	public string Level_Name;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void levelname(){
		Application.LoadLevel(Level_Name);
	}
}
