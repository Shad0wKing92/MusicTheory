using UnityEngine;
using System.Collections;

public class MeasureBarMovement : MonoBehaviour {

	//public float BarSpeed;
	private float amtToMove;
	private NoteManager NM;
	private NoteSpawner NS;
	public bool endBar;

	// Use this for initialization
	void Start () {
		NM = GameObject.FindGameObjectWithTag("NoteManager").GetComponent<NoteManager>();
		NS = GameObject.FindGameObjectWithTag("Spawner").GetComponent<NoteSpawner>();
		this.gameObject.transform.position = new Vector3(transform.position.x, 0, transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
		amtToMove = NM.speed * Time.deltaTime;
		transform.Translate(-Vector2.right * amtToMove);
	}

	void OnTriggerEnter(Collider otherObject){
//		StartCoroutine(UnleashAttackErator());
		if (endBar) {
			NS.Spawned = false;
		}
		NM.UnleashAttack();
		Destroy(gameObject);
	}

//	IEnumerator UnleashAttackErator(){
//		Debug.Log("Enter");
//		yield return new WaitForSeconds(0.5f);
//		NM.UnleashAttack ();
//		Debug.Log("Exit");
//	}
}
