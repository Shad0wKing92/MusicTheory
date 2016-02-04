using UnityEngine;
using System.Collections;

public class BlinkingTitle : MonoBehaviour {

	public float time;
	public GUIText text;

	// Use this for initialization
	void Start () {
		StartCoroutine (blink ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator blink(){
		text.enabled = true;
		yield return new WaitForSeconds (time);
		text.enabled = false;
		yield return new WaitForSeconds (time);
		StartCoroutine (blink ());
	}
}
