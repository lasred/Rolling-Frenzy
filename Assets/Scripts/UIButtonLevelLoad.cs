using UnityEngine;
using System.Collections;


public class UIButtonLevelLoad : MonoBehaviour {
	
	public string LevelToLoad;
	
	public void loadLevel() {
        //Load the level from LevelToLoad
        Debug.Log ("HERE");
		Application.LoadLevel(LevelToLoad);
	}
}
