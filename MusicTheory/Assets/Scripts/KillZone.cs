using UnityEngine;
using System.Collections;

public class KillZone : MonoBehaviour {

	private NoteManager NM;
	private PlayerScript PS;

	public GameObject BadPS;

	// Use this for initialization
	void Start () {
		NM = GameObject.FindGameObjectWithTag("NoteManager").GetComponent<NoteManager>();
		PS = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerScript> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider otherObject){
		if (PS.Health > 0) {
			NM.AddAttackPowerEnemy ();
			Instantiate(BadPS, new Vector3(otherObject.transform.position.x, otherObject.transform.position.y, -0.5f), transform.rotation);
			Destroy (otherObject.gameObject);
		}
		else{
			Instantiate(BadPS, new Vector3(otherObject.transform.position.x, otherObject.transform.position.y, -0.5f), transform.rotation);
			Destroy (otherObject.gameObject);
		}
	}
}
