using UnityEngine;
using System.Collections;

public class onlyonce : MonoBehaviour {
	public targetmove tm;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnCollisionEnter2D (Collision2D other){
		if (other.gameObject.tag == ("Rock")) {

			tm.enabled = true;
		}
	}
}
