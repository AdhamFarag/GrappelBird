using UnityEngine;
using System.Collections;

public class gainonetoselect : MonoBehaviour {
	public int CharacterNo;
	public GameObject wizard;
	public GameObject tim;
	public GameObject batman;

	public GameObject green_arrow;
	public GameObject flash;
	public GameObject R2D2;
	public GameObject iron_man;
	public GameObject Spider_man;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (CharacterNo >= 8) {
			CharacterNo = 7;
		}
		if (CharacterNo < 0) {
			CharacterNo = 0;
		}
		selectup ();
		selectdown ();
	}
	public void selectup(){
		CharacterNo += 1;
		if (CharacterNo == 1) {
			wizard.SetActive (true);
			tim.SetActive (false);
			batman.SetActive (false);

			green_arrow.SetActive(false);
			flash.SetActive(false);
			R2D2.SetActive(false);
			iron_man.SetActive(false);
			Spider_man.SetActive (false);
		}
	 if (CharacterNo == 2) {
			wizard.SetActive (false);
			tim.SetActive (true);
			batman.SetActive(false);

			green_arrow.SetActive(false);
			flash.SetActive(false);
			R2D2.SetActive(false);
			iron_man.SetActive(false);
			Spider_man.SetActive (false);
		}
		if (CharacterNo == 3) {
			wizard.SetActive (false);
			tim.SetActive(false);
			batman.SetActive(true);

			green_arrow.SetActive(false);
			flash.SetActive(false);
			R2D2.SetActive(false);
			iron_man.SetActive(false);
			Spider_man.SetActive (false);
		}

		if (CharacterNo == 4) {
			wizard.SetActive (false);
			tim.SetActive(false);
			batman.SetActive(false);

			green_arrow.SetActive(true);
			flash.SetActive(false);
			R2D2.SetActive(false);
			iron_man.SetActive(false);
			Spider_man.SetActive (false);
		}
		if (CharacterNo == 5) {
			wizard.SetActive (false);
			tim.SetActive(false);
			batman.SetActive(false);

			green_arrow.SetActive(false);
			flash.SetActive(true);
			R2D2.SetActive(false);
			iron_man.SetActive(false);
			Spider_man.SetActive (false);
		}		
		if (CharacterNo == 6) {
			wizard.SetActive (false);
			tim.SetActive(false);
			batman.SetActive(false);

			green_arrow.SetActive(false);
			flash.SetActive(false);
			R2D2.SetActive(true);
			iron_man.SetActive(false);
			Spider_man.SetActive (false);

		}
		if (CharacterNo == 7) {
			wizard.SetActive (false);
			tim.SetActive(false);
			batman.SetActive(false);

			green_arrow.SetActive(false);
			flash.SetActive(false);
			R2D2.SetActive(false);
			iron_man.SetActive(true);
			Spider_man.SetActive (false);
		}
		if (CharacterNo == 8) {
			wizard.SetActive (false);
			tim.SetActive(false);
			batman.SetActive(false);

			green_arrow.SetActive(false);
			flash.SetActive(false);
			R2D2.SetActive(false);
			iron_man.SetActive(false);
			Spider_man.SetActive (true);
		}


	}
	public void selectdown(){
		CharacterNo -= 1;
	}

}
