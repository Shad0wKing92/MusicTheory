using UnityEngine;
using System.Collections;

public class NoteSpawner : MonoBehaviour {

	public GameObject[] NoteList;
	public GameObject Note;
	[HideInInspector]public bool Spawned;

	private NoteManager NM;

	// Use this for initialization
	void Start () {
		NM = GameObject.FindGameObjectWithTag ("NoteManager").GetComponent<NoteManager> ();
		//Spawned = false;
	}
	
	// Update is called once per frame
	void Update () {
//		if (!Spawned) {
//			if (Input.GetKeyDown (spawn)) {
//				NM.spawnSong ();
//				Spawned = true;
//			}
//		}
	}

	void OnGUI(){
		if (!Spawned) {
			if (GUI.Button(new Rect(Screen.width - 120, 10, 100,50), "Jingle Bells")) {
				NM.spawnSong (0);
				Spawned = true;
			}
			if (GUI.Button(new Rect(Screen.width - 120, 60, 100,50), "Other Song")) {
				NM.spawnSong (1);
				Spawned = true;
			}
		}
	}
}
