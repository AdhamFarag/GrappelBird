using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class iconcollect : MonoBehaviour {
	
    public static int score; // The player's score.
    public Text scoretext;   
	public Text hiighscoretext; // Reference to the Text component.
	public static iconcollect iconcolect;
	public int highscore;

	void Start(){
		//StartCoroutine(wait());
		score = 0;


	}
//	public IEnumerator wait (){
	//	while (true) {
	//		yield return new WaitForSeconds(3.0f);
	//		score += 1;
	//	}
		
	//}

  void Awake ()
{
	    iconcolect = this;


	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "coin") {
			score += 10;
			this.GetComponent<AudioSource>().Play();
	
		}
		}

void Update ()
{
		scoretext.text = "score : " + score ;
		hiighscoretext.text = "Highscore : " + highscore;
		highscore = PlayerPrefs.GetInt ("highscore");
		checkhighscore ();
	}



	public void checkhighscore(){
		if (score > highscore) {
			PlayerPrefs.SetInt("highscore",score);

		}
	}


}

