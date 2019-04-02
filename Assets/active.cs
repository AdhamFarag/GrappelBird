using UnityEngine;
using System.Collections;

public class active : MonoBehaviour {

	public GameObject[] ObjectsList; // Not only 18, this script will except any number of game objects you put here.

	void Awake(){
	StartCoroutine(wait ());
	}
	void ins() {
		ObjectsList[Random.Range(0,ObjectsList.Length)].SetActive(true);
		StartCoroutine (wait ());

		   }
	// Update is called once per frame
	void Update () {
		
	}
	public IEnumerator wait(){
		yield return new WaitForSeconds (5.0f);
		ins ();
		
		
	}

}
