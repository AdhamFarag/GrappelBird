using UnityEngine;
using System.Collections;

public class activateset : MonoBehaviour {
	
	public GameObject[] ObjectsList; // Not only 18, this script will except any number of game objects you put here.
	
	void Awake(){
		ObjectsList[Random.Range(0,ObjectsList.Length)].SetActive(true);


	}
	// Update is called once per frame
	void Update () {
		
	}

}
