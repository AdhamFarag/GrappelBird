using UnityEngine;
using System.Collections;

public class cheat : MonoBehaviour {
	public int presses;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (presses == 10) {
			PlayerPrefs.SetInt("money",100000);
			Debug.Log("unlocked");
		}
	}
	public void chater(){
		presses += 1;
	}

}
