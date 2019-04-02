using UnityEngine;
using System.Collections;

public class targetmove : MonoBehaviour {
	
	Vector3 mousePosition,targetPosition;
	
	//To Instantiate TargetObject at mouse position
	public Transform targetObject;
	public float number;
	public GameObject des;
	float distance=10f;
	public findshpere fs;
	public GameObject hook;
	public int savedplayer;
	
	// Use this for initialization
	void Start () {
		savedplayer = PlayerPrefs.GetInt ("selectedPlayer");
		if (savedplayer == 1) {
		
		}
		Time.timeScale = 1;
		fs = GameObject.FindGameObjectWithTag ("Player").GetComponent<findshpere> ();
	}
	
	// Update is called once per frame
	void Update () {
		des = GameObject.FindGameObjectWithTag ("Rock");

		//To get the current mouse position
		mousePosition=Input.mousePosition;
		
		//Convert the mousePosition according to World position
		targetPosition=Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x,mousePosition.y,distance));
		
		//Set the position of targetObject
		targetObject.position=targetPosition;
		
		//Debug.Log(mousePosition+"   "+targetPosition);
		
		
		//If Left Button is clicked
		if(Input.GetMouseButtonUp(0))
		{
			//create the instance of targetObject and place it at given position.
			fs.LR.enabled =true;
			number +=1;
			fs.LR.SetPosition (0, transform.position);
			fs.LR.SetPosition (1, targetObject.transform.position);

			Instantiate(targetObject,targetObject.transform.position,targetObject.transform.rotation);    
			this.enabled = false;
		}
	}




	}
