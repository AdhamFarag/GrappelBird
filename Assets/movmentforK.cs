using UnityEngine;
using System.Collections;

public class movmentforK : MonoBehaviour {
	public int speed = 4;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKeyDown (KeyCode.D)) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed,0);
		}
		else if (Input.GetKeyUp (KeyCode.D)) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0,0);
		}
		else if (Input.GetKeyDown (KeyCode.A)) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-speed,0);
		}
		else if (Input.GetKeyUp (KeyCode.A)) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0,0);
		}

	
	}
	void OnCollisionStay2D (Collision2D other){
		if (other.gameObject.tag == "ground") {
			if (Input.GetKeyDown (KeyCode.W)) {
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 9);
			}
		}
	
	}

}