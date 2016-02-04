using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public int Health;
	public bool dead = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Health <= 0) {
			dead = true;
			Destroy(gameObject);
		}
	}

	void OnGUI(){
		GUI.Label (new Rect (10, 505, 150, 100), ("Player Health: " + Health));
	}
}
