using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnMouseDown(){
		GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0));
	

	}
}
