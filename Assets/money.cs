 using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class money : MonoBehaviour {

	
	public static int coin; // The player's score.
	public Text moneytext;   
	
	void Start(){
}

	
	void Awake ()
	{
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "coin") {
			coin += 1;
			Destroy(other.gameObject);
			PlayerPrefs.SetInt("money",coin);
		}
	}
	
	void Update ()
	{
		moneytext.text = "money : " + coin ;

		coin = PlayerPrefs.GetInt ("money");
	
	}
}

