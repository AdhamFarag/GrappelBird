#pragma strict
//these are the player prefabs that will be automagically plugged in for us.
var player01Prefab : GameObject;
var player02Prefab : GameObject;
var player03Prefab : GameObject;
var player04Prefab : GameObject;
var player05Prefab : GameObject;
var player06Prefab : GameObject;
var player07Prefab : GameObject;
var player08Prefab : GameObject;
var player09Prefab : GameObject;

//this is where the script placed in the level inputs in this number for the player who was selected
//and saved by playerPrefs
var savedPlayer : int = 0;

//this is called first before the Start function, so make sure it loads everthing needed first.
function Awake() {
setzero();
	savedPlayer = 0;
	// Let's grab the saved data for each player and grab that integer to use to load that player in the world
	savedPlayer = PlayerPrefs.GetInt("selectedPlayer");
		

	
	
	if(savedPlayer == 0) //if we've not selected any player initially lets just use Player 1 
        {  					
		player01Prefab.SetActiveRecursively(true);
		player02Prefab.SetActiveRecursively(false);
		player03Prefab.SetActiveRecursively(false);
		}
	else if(savedPlayer == 1) //if we've set the player to 1 from playerprefs then 
        {  					
		player01Prefab.SetActiveRecursively(true);
		player02Prefab.SetActiveRecursively(false);
		player03Prefab.SetActiveRecursively(false);
        }
	else if(savedPlayer == 2) //if we've set the player to 2 from playerprefs then 
        {  					
		player02Prefab.SetActiveRecursively(true);
		player01Prefab.SetActiveRecursively(false);
		player03Prefab.SetActiveRecursively(false);
        }
    else if(savedPlayer == 3) //if we've set the player to 3 from playerprefs then 
        {  					
		player03Prefab.SetActiveRecursively(true);
		player01Prefab.SetActiveRecursively(false);
		player02Prefab.SetActiveRecursively(false);
		
        }
        else if(savedPlayer == 4) //if we've set the player to 4 from playerprefs then 
        {  					
          player04Prefab.SetActiveRecursively(true);
        }
                
        else if(savedPlayer == 5) //if we've set the player to 4 from playerprefs then 
        {  					
          player05Prefab.SetActiveRecursively(true);
        }
            else if(savedPlayer == 6) //if we've set the player to 4 from playerprefs then 
        {  					
          player06Prefab.SetActiveRecursively(true);
        }
             else if(savedPlayer == 7) //if we've set the player to 4 from playerprefs then 
        {  					
          player07Prefab.SetActiveRecursively(true);
        }
           else if(savedPlayer == 8) //if we've set the player to 4 from playerprefs then 
        {  					
          player08Prefab.SetActiveRecursively(true);
        }
            else if(savedPlayer == 9) //if we've set the player to 4 from playerprefs then 
        {  					
          player09Prefab.SetActiveRecursively(true);
        }
        
}
function setzero(){
	 PlayerPrefs.GetInt("selectedPlayer",0);
}


