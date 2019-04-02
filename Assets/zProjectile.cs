using UnityEngine;
using System.Collections;

public class zProjectile : MonoBehaviour {
	public float thrust;
	public Rigidbody2D rb;
	void Start() {
		rb = GetComponent<Rigidbody2D>();
	}
	void FixedUpdate() {
		rb.AddForce(transform.forward * thrust);
	}
}
