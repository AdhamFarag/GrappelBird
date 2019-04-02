using UnityEngine;
using System.Collections;

public class symbol : MonoBehaviour {
	public targetmove TM;
	public Transform mic;
	public Transform batsymbol;
	public Transform gift;
	public Transform bow;
	public Transform bolt;
	public Transform lightsaber;
	public Transform reactor;
	public Transform spider;
	public int savedplayer;
	// Use this for initialization
	void Start () {
		TM = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<targetmove> ();
	}
	
	// Update is called once per frame
	void Update () {
		savedplayer = PlayerPrefs.GetInt ("selectedPlayer");
		if (savedplayer == 2) {
			TM.targetObject = mic;
		}
		if (savedplayer == 3) {
			TM.targetObject = batsymbol;
		}
		if (savedplayer == 4) {
			TM.targetObject = gift;
		}
			
		if (savedplayer == 5) {
			TM.targetObject = bow;
		}
		if (savedplayer == 6) {
			TM.targetObject = bolt;
		}
		if (savedplayer == 7) {
			TM.targetObject = lightsaber;
		}
		if (savedplayer == 8) {
			TM.targetObject = reactor;
		}
		if (savedplayer == 9) {
			TM.targetObject = spider;
		}
			
	}

}
