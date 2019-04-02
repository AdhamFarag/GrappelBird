using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class losehealth : MonoBehaviour {
	public int Health;
	public GameObject pause;
	public GameObject HS;
	public GameObject losepic;
	public targetmove TM;
	public GameObject restart;
	public bool lost;
	public int gameslost;
	public GameObject shop;


	void Start () {
//		if (Advertisement.isSupported) {
//			Advertisement.Initialize ("1022409");
//		} else {
//			Debug.Log("Platform not supported");
//		}
		Health = 1;
		losepic.SetActive (false);
	}
	

	void Update () {
	 gameslost = PlayerPrefs.GetInt("gameslost");
		if (gameslost >= 5){
			PlayerPrefs.SetInt("gameslost",0);
			//RYRU();
			pause.SetActive(false);
		}
		if (Health == 0) {
			losepic.SetActive(true);
		}

	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Fire") {

			Health = 0;
			Time.timeScale = 0;
			TM.enabled = false;
			lost = true;
			HS.SetActive(true);
			restart.SetActive(true);
			shop.SetActive(true);
			pause.SetActive(false);
			gameslost +=1;
			PlayerPrefs.SetInt("gameslost",gameslost);
		}

	}

//	void RYRU() {
//		Advertisement.IsReady ();
//		// Show with default zone, pause engine and print result to debug log
//		Advertisement.Show(null, new ShowOptions {
//			resultCallback = result => {
//				Debug.Log(result.ToString());
//			}
//				});
//	}

}