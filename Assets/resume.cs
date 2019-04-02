using UnityEngine;
using System.Collections;

public class resume : MonoBehaviour {
	public GameObject pausemenu;
	public targetmove TM;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Resume(){
		Time.timeScale = 1;
		pausemenu.SetActive (false);
		TM.enabled = true;
	}
}
