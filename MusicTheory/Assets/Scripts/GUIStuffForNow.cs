using UnityEngine;
using System.Collections;

public class GUIStuffForNow : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnGUI(){
		if(GUI.Button(new Rect(Screen.width - Screen.width/4 - Screen.width/4 - Screen.width/4, 200, 100, 50), "Credits")){
			Application.LoadLevel(2);
		}
		if(GUI.Button(new Rect(Screen.width - Screen.width/2, 200, 100, 50), "Play")){
			Application.LoadLevel(1);
		}
		if(GUI.Button(new Rect(Screen.width - Screen.width/4, 200, 100, 50), "How To Do?")){
			//Application.LoadLevel();
		}
		if(GUI.Button(new Rect(Screen.width - Screen.width/2, 400, 100, 50), "Quit")){
			Application.Quit();
		}
	}
}
