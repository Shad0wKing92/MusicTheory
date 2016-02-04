using UnityEngine;
using System.Collections;

public class RestMovement : MonoBehaviour {

	//public float RestSpeed;
	private float amtToMove;
	private NoteManager NM;
	private bool inZone = false;
	public GameObject GoodPS;

	// Use this for initialization
	void Start () {
		NM = GameObject.FindGameObjectWithTag("NoteManager").GetComponent<NoteManager>();
		this.gameObject.transform.position = new Vector3(transform.position.x, 0, transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
		amtToMove = NM.speed * Time.deltaTime;
		transform.Translate(-Vector2.right * amtToMove);

		if(!Input.anyKeyDown){
			if(inZone){
				NM.AddAttackPowerPlayer();
				Instantiate(GoodPS, new Vector3(this.transform.position.x, this.transform.position.y, -0.5f), transform.rotation);
				Destroy(gameObject);
			}
		}
		else{
			gameObject.GetComponent<Collider>().enabled = false;
		}
		if (!Input.anyKey) {
			gameObject.GetComponent<Collider>().enabled = true;
		}
	}

	void OnTriggerEnter (Collider otherObject) {
		inZone = true;
	}
	
	void OnTriggerExit (Collider otherObject){
		inZone = false;
	}
}
