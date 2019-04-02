using UnityEngine;
using System.Collections;

public class destroythis : MonoBehaviour {
	public string collider_name;
	// Use this for initialization
	void Start () {
		this.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.name == collider_name) {
			StartCoroutine(wait());

		}
	}
	public IEnumerator wait(){
		yield return new WaitForSeconds (1.0f);
		Destroy (this.gameObject);
	}

}
