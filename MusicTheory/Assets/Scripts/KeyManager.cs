using UnityEngine;
using System.Collections;

public class KeyManager : MonoBehaviour {

	public KeyCode MiddleC;
	public KeyCode CSharp;
	public KeyCode D;
	public KeyCode DSharp;
	public KeyCode E;
	public KeyCode F;
	public KeyCode FSharp;
	public KeyCode G;
	public KeyCode GSharp;
	public KeyCode A;
	public KeyCode ASharp;
	public KeyCode B;
	public KeyCode HighC;
	public KeyCode HighCSharp;
	public KeyCode HighD;
	public KeyCode HighDSharp;
	public KeyCode HighE;
	public KeyCode HighF;

	public KeyCode upSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(upSpeed)){
			Time.timeScale = 4.0f;
		}
		if(Input.GetKeyUp(upSpeed)){
			Time.timeScale = 1.0f;
		}
	}
}
