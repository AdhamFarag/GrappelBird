using UnityEngine;
using System.Collections;

public class thrusters : MonoBehaviour {
	public GameObject thruster;
	public Transform orig;
	public Transform thiss;
	// Use this for initialization
	void Start () {
		orig.position = new Vector2(0,0);
	}
	
	// Update is called once per frame
	void Update () {
		if (thiss.position.y>orig.position.y) {
			thruster.SetActive (true);
		}
	}
}
