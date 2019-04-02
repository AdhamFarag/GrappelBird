using UnityEngine;
using System.Collections;

public class findshpere : MonoBehaviour {
	public DistanceJoint2D ds;
	public GameObject sphere;
	public LineRenderer LR;
	public targetmove targetm;
	// Use this for initialization
	void Start () {
		LR = GameObject.FindGameObjectWithTag("Player").GetComponent<LineRenderer>();
		sphere = GameObject.FindGameObjectWithTag("Rock");		
	



	}
	
	// Update is called once per frame
	void Update () {
		ds.connectedBody = GameObject.FindGameObjectWithTag("Rock").GetComponent<Rigidbody2D>();
		LR.SetPosition (0, transform.position);
		LR.SetPosition (1, sphere.transform.position);
	

	}
	void OnCollsionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Rock") {

			Destroy(other.gameObject);
			LR.enabled = false;
		}
	}



}
