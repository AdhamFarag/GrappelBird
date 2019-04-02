using UnityEngine;
using System.Collections;

public class destroyhook : MonoBehaviour {
	public LineRenderer LR;
	public Material mat;
	// Use this for initialization
	void Start () {
		mat = LR.material;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Rock" ) {
			Destroy(other.gameObject);
			LR.enabled = false;
		}
	}
}
