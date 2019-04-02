using UnityEngine;
using System.Collections;

public class Lookattarget : MonoBehaviour {
	public Transform target;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(target);
	}
}
