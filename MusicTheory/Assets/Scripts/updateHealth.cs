using UnityEngine;
using System.Collections;

public class updateHealth : MonoBehaviour {

	// initialize the gameObject
	private GameObject hB;
	// global variable for the intial height & middle point & the bottom of the cube
	public float initialMiddlePoint;
	public float initialHeight;
	public float cubeBottom;


	// Use this for initialization
	void Start () {
		// find the health object (cube)
		hB = GameObject.Find("Health");

		// get the initial height and middle point of the object and calculate its bottom side
		initialMiddlePoint = hB.transform.position.y;
		initialHeight = hB.GetComponent<Renderer>().bounds.size.y;
		cubeBottom = initialMiddlePoint - initialHeight/2;

		// call Health function with the two parameters
		setHealth(50, 50);
	}
	
	// Update is called once per frame
	void Update () {

	}



	void setHealth(int maxHealth, int currentHealth){
		// get the currentSize of the health bar
		float currentSize = hB.GetComponent<Renderer>().bounds.size.y;
		 /*float currentPosition = hB.transform.position.y;*/

		// calculate the ration between the maximum health and the current health
		float ratio = (float)maxHealth/(float)currentHealth;

		// calculate the new objectss height
		float objectHeight = currentSize/ratio;    

		// calculte its new position
		float newPosition = cubeBottom + objectHeight/2; // calculate the new position of the cube

		// set the new height & new position
		hB.transform.localScale = new Vector3(1.0f, objectHeight, 1.0f);
		hB.transform.position = new Vector3(hB.transform.position.x, newPosition, hB.transform.position.z);
	}



}
