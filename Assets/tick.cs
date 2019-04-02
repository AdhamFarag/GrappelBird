using UnityEngine;
using System.Collections;

public class tick : MonoBehaviour {
	public int savednumber;
	public GameObject tick1;
	public GameObject tick2;
	public GameObject tick3;
	public GameObject tick4;
	public GameObject tick5;
	public GameObject tick6;
	public GameObject tick7;
	public GameObject tick8;
	public GameObject tick9;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		savednumber = PlayerPrefs.GetInt ("selectedPlayer");
		if (savednumber == 0) {
			tick1.SetActive(true);
			tick2.SetActive(false);
			tick3.SetActive(false);

			tick5.SetActive(false);
			tick6.SetActive(false);
			tick7.SetActive(false);
			tick8.SetActive(false);
			tick9.SetActive (false);
		}
		if (savednumber == 1) {
			tick1.SetActive(true);
			tick2.SetActive(false);
			tick3.SetActive(false);

			tick5.SetActive(false);
			tick6.SetActive(false);
			tick7.SetActive(false);
			tick8.SetActive(false);
			tick9.SetActive (false);
		}
		if (savednumber == 2) {
			tick1.SetActive(false);
			tick2.SetActive(true);
			tick3.SetActive(false);

			tick5.SetActive(false);
			tick6.SetActive(false);
			tick7.SetActive(false);
			tick8.SetActive(false);
			tick9.SetActive (false);
		}
		if (savednumber == 3) {
			tick1.SetActive(false);
			tick2.SetActive(false);
			tick3.SetActive(true);

			tick5.SetActive(false);
			tick6.SetActive(false);
			tick7.SetActive(false);
			tick8.SetActive(false);
			tick9.SetActive (false);
		}
	
		if (savednumber == 5) {
			tick1.SetActive(false);
			tick2.SetActive(false);
			tick3.SetActive(false);

			tick5.SetActive(true);
			tick6.SetActive(false);
			tick7.SetActive(false);
			tick8.SetActive(false);
			tick9.SetActive (false);
		}
		if (savednumber == 6) {
			tick1.SetActive(false);
			tick2.SetActive(false);
			tick3.SetActive(false);

			tick5.SetActive(false);
			tick6.SetActive(true);
			tick7.SetActive(false);
			tick8.SetActive(false);
			tick9.SetActive (false);
		}
		if (savednumber == 7) {
			tick1.SetActive(false);
			tick2.SetActive(false);
			tick3.SetActive(false);

			tick5.SetActive(false);
			tick6.SetActive(false);
			tick7.SetActive(true);
			tick8.SetActive(false);
			tick9.SetActive (false);
		}
		if (savednumber == 8) {
			tick1.SetActive(false);
			tick2.SetActive(false);
			tick3.SetActive(false);

			tick5.SetActive(false);
			tick6.SetActive(false);
			tick7.SetActive(false);
			tick8.SetActive(true);
			tick9.SetActive (false);
		}
		if (savednumber == 9) {
			tick1.SetActive(false);
			tick2.SetActive(false);
			tick3.SetActive(false);

			tick5.SetActive(false);
			tick6.SetActive(false);
			tick7.SetActive(false);
			tick8.SetActive(false);
			tick9.SetActive (true);
		}

	}
}

