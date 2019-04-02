using UnityEngine;
using System.Collections;

public class buy : MonoBehaviour {
	public GameObject locklevel;
	public int money;
	public bool keepb;
	public int keep;
	public  int mineus;
	public string key;
	// Use this for initialization
	void Start () {
		mineus = PlayerPrefs.GetInt("money");
		checkbuy ();
	

	}
	
	// Update is called once per frame
	void Update () {
		mineus = PlayerPrefs.GetInt("money");


	}
	public void OnMouseDown(){
		if (PlayerPrefs.GetInt ("money") >= money) {
			keepb = true;

			locklevel.SetActive(false);
			PlayerPrefs.SetInt(key,1);
		}
		keep = 1;
	}
	public void checkbuy(){
		if (PlayerPrefs.HasKey (key)) {
			locklevel.SetActive(false);
	
		//PlayerPrefs.SetInt("money",mineus);

		}
		
		}
	public void minus(){
		if (mineus >= money) {
			mineus -= money;
			PlayerPrefs.SetInt("money",mineus);

	}

	}

}