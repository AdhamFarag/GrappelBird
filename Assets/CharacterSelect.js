#pragma strict
//this is the currently selected Player. Also the one that will be saved to PlayerPrefs
var selectedPlayer : int = 0;
function Update() 
{ 
if (Input.GetMouseButtonUp (0)) {
	var ray = Camera.main.ScreenPointToRay (Input.mousePosition);
	var hit : RaycastHit;
	
	if (Physics.Raycast (ray, hit, 100))
		{
				// The pink text is where you would put the name of the object you want to click on (has attached collider).
				
	            if(hit.collider.name == "Player") 
				SelectedCharacter1(); //Sends this click down to a function called "SelectedCharacter1(). Which is where all of our stuff happens.
			
				if(hit.collider.name == "tim")
				SelectedCharacter2();
					
				if(hit.collider.name == "camophlage")
				SelectedCharacter3();
		} 
		else
		{
		return;               
		}
	} 
}

function SelectedCharacter1() {
	Debug.Log ("Character 1 SELECTED"); //Print out in the Unity console which character was selected.
	selectedPlayer = 1;

	PlayerPrefs.SetInt("selectedPlayer", (selectedPlayer));
}

function SelectedCharacter2() {
	Debug.Log ("Character 2 SELECTED");
	selectedPlayer = 2;
	PlayerPrefs.HasKey("7");
	PlayerPrefs.SetInt("selectedPlayer", (selectedPlayer));
}

function SelectedCharacter3() {
	Debug.Log ("Character 3 SELECTED");
	selectedPlayer = 3;
		PlayerPrefs.HasKey("13");
	PlayerPrefs.SetInt("selectedPlayer", (selectedPlayer));
}
function SelectedCharacter4() {
	Debug.Log ("Character 4 SELECTED");
	selectedPlayer = 4;

	PlayerPrefs.SetInt("selectedPlayer", (selectedPlayer));
}
function SelectedCharacter5() {
	Debug.Log ("Character 5 SELECTED");
	selectedPlayer = 5;

	PlayerPrefs.SetInt("selectedPlayer", (selectedPlayer));
}
function SelectedCharacter6() {
	Debug.Log ("Character 6 SELECTED");
	selectedPlayer = 6;

	PlayerPrefs.SetInt("selectedPlayer", (selectedPlayer));
}
function SelectedCharacter7() {
	Debug.Log ("Character 7 SELECTED");
	selectedPlayer = 7;

	PlayerPrefs.SetInt("selectedPlayer", (selectedPlayer));
}
function SelectedCharacter8() {
	Debug.Log ("Character 8 SELECTED");
	selectedPlayer = 8;

	PlayerPrefs.SetInt("selectedPlayer", (selectedPlayer));
}
function SelectedCharacter9() {
	Debug.Log ("Character 9 SELECTED");
	selectedPlayer = 9;

	PlayerPrefs.SetInt("selectedPlayer", (selectedPlayer));
}


