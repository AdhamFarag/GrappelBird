using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pause : MonoBehaviour {
	public GameObject pausemenu;
	public targetmove TM;
	public Text gamesplayed;
	public int noofgames;
	// Use this for initialization
	void Start () {
	noofgames = PlayerPrefs.GetInt("no of games");
		gamesplayed.text = "Games played: " + noofgames;
		noofgames += 1;
	}
	
	// Update is called once per frame
	void Update () {
		PlayerPrefs.SetInt("no of games",noofgames);
	}
	public void Pause1(){
		Time.timeScale = 0;
		pausemenu.SetActive (true);
		TM.enabled = false;

	}
}
