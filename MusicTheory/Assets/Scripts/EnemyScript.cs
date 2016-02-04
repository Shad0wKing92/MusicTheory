using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	public int enemyHealth;
	public bool enemyDead = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (enemyHealth <= 0) {
			enemyDead = true;
			Destroy(gameObject);
		}
	}

	void OnGUI(){
		GUI.Label (new Rect (10, 520, 150, 100), ("Enemy Health: " + enemyHealth));
	}
}
