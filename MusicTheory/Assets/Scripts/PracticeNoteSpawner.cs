using UnityEngine;
using System.Collections;

public class PracticeNoteSpawner : MonoBehaviour {
	
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
			if (GUI.Button(new Rect(10, 60, 50,50), "Mid C")) {
				NM.spawnSong (0);
			}
			if (GUI.Button(new Rect(60, 60, 50,50), "C#")) {
				NM.spawnSong (1);
			}
			if (GUI.Button(new Rect(110, 60, 50,50), "D")) {
				NM.spawnSong (2);
			}
			if (GUI.Button(new Rect(160, 60, 50,50), "D#")) {
				NM.spawnSong (3);
			}
			if (GUI.Button(new Rect(210, 60, 50,50), "E")) {
				NM.spawnSong (4);
			}
			if (GUI.Button(new Rect(260, 60, 50,50), "F")) {
				NM.spawnSong (5);
			}
			if (GUI.Button(new Rect(310, 60, 50,50), "F#")) {
				NM.spawnSong (6);
			}
			if (GUI.Button(new Rect(360, 60, 50,50), "G")) {
				NM.spawnSong (7);
			}
			if (GUI.Button(new Rect(410, 60, 50,50), "G#")) {
				NM.spawnSong (8);
			}
			if (GUI.Button(new Rect(460, 60, 50,50), "A")) {
				NM.spawnSong (9);
			}
			if (GUI.Button(new Rect(510, 60, 50,50), "A#")) {
				NM.spawnSong (10);
			}
			if (GUI.Button(new Rect(560, 60, 50,50), "B")) {
				NM.spawnSong (11);
			}
			if (GUI.Button(new Rect(610, 60, 50,50), "HighC")) {
				NM.spawnSong (12);
			}
			if (GUI.Button(new Rect(660, 60, 50,50), "HighC#")) {
				NM.spawnSong (13);
			}
			if (GUI.Button(new Rect(710, 60, 50,50), "HighD")) {
				NM.spawnSong (14);
			}
			if (GUI.Button(new Rect(760, 60, 50,50), "HighD#")) {
				NM.spawnSong (15);
			}
			if (GUI.Button(new Rect(810, 60, 50,50), "HighE")) {
				NM.spawnSong (16);
			}
			if (GUI.Button(new Rect(860, 60, 50,50), "HighF")) {
				NM.spawnSong (17);
			}
			if (GUI.Button(new Rect(910, 60, 50,50), "Rest")) {
				NM.spawnSong (17);
			}
	}
}
