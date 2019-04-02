using UnityEngine;
using System.Collections;

public class activateshooter : MonoBehaviour {
	public active actic;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine (wait ());

		
	}
	public IEnumerator wait(){
		yield return new WaitForSeconds (10.0f);
		actic.enabled = true;


	}
}
