using UnityEngine;
using System.Collections;

public class NoteMovement : MonoBehaviour {

	//public float NoteSpeed;
	private float amtToMove;
	public string noteName;
	private NoteManager NM;
	private SoundManagerScript SMS;
	public enum note {MiddleC, CSharp, D, DSharp, E, F, FSharp, G, GSharp, A, ASharp, B, HighC, HighCSharp, HighD, HighDSharp, HighE, HighF}
	public GameObject KeyCodeIndex;
	note currentNote;
	private GameObject killZone;
	public GameObject goodPS;
	[HideInInspector]public bool inZone = false;
	[HideInInspector]public float Yposition;
	// Use this for initialization
	void Start () {
		NM = GameObject.FindGameObjectWithTag("NoteManager").GetComponent<NoteManager>();
		//SMS = GameObject.FindGameObjectWithTag ("SoundManager").GetComponent<SoundManagerScript> ();

		SMS = SoundManagerScript.Instance;

		if(noteName == "MiddleC"){
			currentNote = note.MiddleC;
			Yposition = -1.5f;
		}
		if(noteName == "CSharp"){
			currentNote = note.CSharp;
			Yposition = -1.5f;
		}
		if(noteName == "D"){
			currentNote = note.D;
			Yposition = -1.25f;
		}
		if(noteName == "DSharp"){
			currentNote = note.DSharp;
			Yposition = -1.25f;
		}
		if(noteName == "E"){
			currentNote = note.E;
			Yposition = -1f;
		}
		if(noteName == "F"){
			currentNote = note.F;
			Yposition = -0.75f;
		}
		if(noteName == "FSharp"){
			currentNote = note.FSharp;
			Yposition = -0.75f;
		}
		if(noteName == "G"){
			currentNote = note.G;
			Yposition = -0.5f;
		}
		if(noteName == "GSharp"){
			currentNote = note.GSharp;
			Yposition = -0.5f;
		}
		if(noteName == "A"){
			currentNote = note.A;
			Yposition = -0.25f;
		}
		if(noteName == "ASharp"){
			currentNote = note.ASharp;
			Yposition = -0.25f;
		}
		if(noteName == "B"){
			currentNote = note.B;
			Yposition = 0f;
		}
		if(noteName == "HighC"){
			currentNote = note.HighC;
			Yposition = 0.25f;
		}
		if(noteName == "HighCSharp"){
			currentNote = note.HighCSharp;
			Yposition = 0.25f;
		}
		if(noteName == "HighD"){
			currentNote = note.HighD;
			Yposition = 0.5f;
		}
		if(noteName == "HighDSharp"){
			currentNote = note.HighDSharp;
			Yposition = 0.5f;
		}
		if(noteName == "HighE"){
			currentNote = note.HighE;
			Yposition = 0.75f;
		}
		if(noteName == "HighF"){
			currentNote = note.HighF;
			Yposition = 1f;
		}
		this.gameObject.transform.position = new Vector3(transform.position.x, Yposition, transform.position.z);
	}

	// Update is called once per frame
	void Update () {
		amtToMove = NM.speed * Time.deltaTime;
		transform.Translate(-Vector2.right * amtToMove);

		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().MiddleC)){
			if(currentNote == note.MiddleC && inZone){
				NM.AddAttackPowerPlayer();
				Instantiate(goodPS, new Vector3(this.transform.position.x, this.transform.position.y, -0.5f), transform.rotation);
				SMS.MiddleC.Play();
				Destroy(gameObject);

				//play sound LowC
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().CSharp)){
			if(currentNote == note.CSharp && inZone){
				NM.AddAttackPowerPlayer();
				Instantiate(goodPS, new Vector3(this.transform.position.x, this.transform.position.y, -0.5f), transform.rotation);
				SMS.CSharp.Play();
				Destroy(gameObject);
				//play sound LowCSharp
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().D)){
			if(currentNote == note.D && inZone){
				NM.AddAttackPowerPlayer();
				Instantiate(goodPS, new Vector3(this.transform.position.x, this.transform.position.y, -0.5f), transform.rotation);
				SMS.D.Play();
				Destroy(gameObject);
				//play sound LowD
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().DSharp)){
			if(currentNote == note.DSharp && inZone){
				NM.AddAttackPowerPlayer();
				Instantiate(goodPS, new Vector3(this.transform.position.x, this.transform.position.y, -0.5f), transform.rotation);
				SMS.DSharp.Play();
				Destroy(gameObject);
				//play sound LowE
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().E)){
			if(currentNote == note.E && inZone){
				NM.AddAttackPowerPlayer();
				Instantiate(goodPS, new Vector3(this.transform.position.x, this.transform.position.y, -0.5f), transform.rotation);
				SMS.E.Play();
				Destroy(gameObject);
				//play sound LowE
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().F)){
			if(currentNote == note.F && inZone){
				NM.AddAttackPowerPlayer();
				Instantiate(goodPS, new Vector3(this.transform.position.x, this.transform.position.y, -0.5f), transform.rotation);
				SMS.F.Play();
				Destroy(gameObject);
				//play sound LowF
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().FSharp)){
			if(currentNote == note.FSharp && inZone){
				NM.AddAttackPowerPlayer();
				Instantiate(goodPS, new Vector3(this.transform.position.x, this.transform.position.y, -0.5f), transform.rotation);
				SMS.FSharp.Play();
				Destroy(gameObject);
				//play sound LowF
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().G)){
			if(currentNote == note.G && inZone){
				NM.AddAttackPowerPlayer();
				Instantiate(goodPS, new Vector3(this.transform.position.x, this.transform.position.y, -0.5f), transform.rotation);
				SMS.G.Play();
				Destroy(gameObject);
				//play sound LowG
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().GSharp)){
			if(currentNote == note.GSharp && inZone){
				NM.AddAttackPowerPlayer();
				Instantiate(goodPS, new Vector3(this.transform.position.x, this.transform.position.y, -0.5f), transform.rotation);
				SMS.GSharp.Play();
				Destroy(gameObject);
				//play sound LowF
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().A)){
			if(currentNote == note.A && inZone){
				NM.AddAttackPowerPlayer();
				Instantiate(goodPS, new Vector3(this.transform.position.x, this.transform.position.y, -0.5f), transform.rotation);
				SMS.A.Play();
				Destroy(gameObject);
				//play sound LowA
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().ASharp)){
			if(currentNote == note.ASharp && inZone){
				NM.AddAttackPowerPlayer();
				Instantiate(goodPS, new Vector3(this.transform.position.x, this.transform.position.y, -0.5f), transform.rotation);
				SMS.ASharp.Play();
				Destroy(gameObject);
				//play sound LowF
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().B)){
			if(currentNote == note.B && inZone){
				NM.AddAttackPowerPlayer();
				Instantiate(goodPS, new Vector3(this.transform.position.x, this.transform.position.y, -0.5f), transform.rotation);
				SMS.B.Play();
				Destroy(gameObject);
				//play sound MidB
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().HighC)){
			if(currentNote == note.HighC && inZone){
				NM.AddAttackPowerPlayer();
				Instantiate(goodPS, new Vector3(this.transform.position.x, this.transform.position.y, -0.5f), transform.rotation);
				SMS.HighC.Play();
				Destroy(gameObject);
				//play sound HighC
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().HighCSharp)){
			if(currentNote == note.HighCSharp && inZone){
				NM.AddAttackPowerPlayer();
				Instantiate(goodPS, new Vector3(this.transform.position.x, this.transform.position.y, -0.5f), transform.rotation);
				SMS.HighCSharp.Play();
				Destroy(gameObject);
				//play sound HighC
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().HighD)){
			if(currentNote == note.HighD && inZone){
				NM.AddAttackPowerPlayer();
				Instantiate(goodPS, new Vector3(this.transform.position.x, this.transform.position.y, -0.5f), transform.rotation);
				SMS.HighD.Play();
				Destroy(gameObject);
				//play sound HighD
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().HighDSharp)){
			if(currentNote == note.HighDSharp && inZone){
				NM.AddAttackPowerPlayer();
				Instantiate(goodPS, new Vector3(this.transform.position.x, this.transform.position.y, -0.5f), transform.rotation);
				SMS.HighDSharp.Play();
				Destroy(gameObject);
				//play sound HighC
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().HighE)){
			if(currentNote == note.HighE && inZone){
				NM.AddAttackPowerPlayer();
				Instantiate(goodPS, new Vector3(this.transform.position.x, this.transform.position.y, -0.5f), transform.rotation);
				SMS.HighE.Play();
				Destroy(gameObject);
				//play sound HighE
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().HighF)){
			if(currentNote == note.HighF && inZone){
				NM.AddAttackPowerPlayer();
				Instantiate(goodPS, new Vector3(this.transform.position.x, this.transform.position.y, -0.5f), transform.rotation);
				SMS.HighF.Play();
				Destroy(gameObject);
				//play sound HighF
			}
		}
	}

	void OnTriggerEnter (Collider otherObject) {
		inZone = true;
	}

	void OnTriggerExit (Collider otherObject){
		inZone = false;
	}
}
