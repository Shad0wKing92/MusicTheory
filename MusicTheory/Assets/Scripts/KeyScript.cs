using UnityEngine;
using System.Collections;

public class KeyScript : MonoBehaviour {

//	public Transform gameManager;
	public GameObject KeyCodeIndex;
	public GameObject notes;
	public string keyName;
	public enum key {MiddleC, CSharp, D, DSharp, E, F, FSharp, G, GSharp, A, ASharp, B, HighC, HighCSharp, HighD, HighDSharp, HighE, HighF};
	private bool keyInZone;
	key currentKey;
	// Use this for initialization
	void Start () {

		//keyInZone = NoteMovement.inZone;
//		GameObject notes = GameObject.FindGameObjectWithTag("Note");
		NoteMovement noteMovement = notes.GetComponent<NoteMovement>();
		//noteScript = gameObject.GetComponent<GameObject>();

		if(keyName == "MiddleC"){
			currentKey = key.MiddleC;
		}
		if(keyName == "CSharp"){
			currentKey = key.CSharp;
		}
		if(keyName == "D"){
			currentKey = key.D;
		}
		if(keyName == "DSharp"){
			currentKey = key.DSharp;
		}
		if(keyName == "E"){
			currentKey = key.E;
		}
		if(keyName == "F"){
			currentKey = key.F;
		}
		if (keyName == "FSharp") {
			currentKey = key.FSharp;
		}
		if(keyName == "G"){
			currentKey = key.G;
		}
		if (keyName == "GSharp") {
			currentKey = key.GSharp;
		}
		if(keyName == "A"){
			currentKey = key.A;
		}
		if (keyName == "ASharp") {
			currentKey = key.ASharp;
		}
		if(keyName == "B"){
			currentKey = key.B;
		}
		if(keyName == "HighC"){
			currentKey = key.HighC;
		}
		if (keyName == "HighCSharp") {
			currentKey = key.HighCSharp;
		}
		if(keyName == "HighD"){
			currentKey = key.HighD;
		}
		if (keyName == "HighDSharp") {
			currentKey = key.HighDSharp;
		}
		if(keyName == "HighE"){
			currentKey = key.HighE;
		}
		if(keyName == "HighF"){
			currentKey = key.HighF;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().MiddleC)){
			if(currentKey == key.MiddleC){
				GetComponent<Renderer>().material.color = Color.blue;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().MiddleC)){
			if(currentKey == key.MiddleC){
				GetComponent<Renderer>().material.color = Color.white;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().CSharp)){
			if(currentKey == key.CSharp){
				GetComponent<Renderer>().material.color = Color.blue;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().CSharp)){
			if(currentKey == key.CSharp){
				GetComponent<Renderer>().material.color = Color.black;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().D)){
			if(currentKey == key.D){
				GetComponent<Renderer>().material.color = Color.blue;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().D)){
			if(currentKey == key.D){
				GetComponent<Renderer>().material.color = Color.white;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().DSharp)){
			if(currentKey == key.DSharp){
				GetComponent<Renderer>().material.color = Color.blue;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().DSharp)){
			if(currentKey == key.DSharp){
				GetComponent<Renderer>().material.color = Color.black;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().E)){
			if(currentKey == key.E){
				GetComponent<Renderer>().material.color = Color.blue;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().E)){
			if(currentKey == key.E){
				GetComponent<Renderer>().material.color = Color.white;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().F)){
			if(currentKey == key.F){
				GetComponent<Renderer>().material.color = Color.blue;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().F)){
			if(currentKey == key.F){
				GetComponent<Renderer>().material.color = Color.white;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().FSharp)){
			if(currentKey == key.FSharp){
				GetComponent<Renderer>().material.color = Color.blue;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().FSharp)){
			if(currentKey == key.FSharp){
				GetComponent<Renderer>().material.color = Color.black;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().G)){
			if(currentKey == key.G){
				GetComponent<Renderer>().material.color = Color.blue;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().G)){
			if(currentKey == key.G){
				GetComponent<Renderer>().material.color = Color.white;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().GSharp)){
			if(currentKey == key.GSharp){
				GetComponent<Renderer>().material.color = Color.blue;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().GSharp)){
			if(currentKey == key.GSharp){
				GetComponent<Renderer>().material.color = Color.black;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().A)){
			if(currentKey == key.A){
				GetComponent<Renderer>().material.color = Color.blue;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().A)){
			if(currentKey == key.A){
				GetComponent<Renderer>().material.color = Color.white;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().ASharp)){
			if(currentKey == key.ASharp){
				GetComponent<Renderer>().material.color = Color.blue;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().ASharp)){
			if(currentKey == key.ASharp){
				GetComponent<Renderer>().material.color = Color.black;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().B)){
			if(currentKey == key.B){
				GetComponent<Renderer>().material.color = Color.blue;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().B)){
			if(currentKey == key.B){
				GetComponent<Renderer>().material.color = Color.white;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().HighC)){
			if(currentKey == key.HighC){
				GetComponent<Renderer>().material.color = Color.blue;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().HighC)){
			if(currentKey == key.HighC){
				GetComponent<Renderer>().material.color = Color.white;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().HighCSharp)){
			if(currentKey == key.HighCSharp){
				GetComponent<Renderer>().material.color = Color.blue;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().HighCSharp)){
			if(currentKey == key.HighCSharp){
				GetComponent<Renderer>().material.color = Color.black;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().HighD)){
			if(currentKey == key.HighD){
				GetComponent<Renderer>().material.color = Color.blue;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().HighD)){
			if(currentKey == key.HighD){
				GetComponent<Renderer>().material.color = Color.white;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().HighDSharp)){
			if(currentKey == key.HighDSharp){
				GetComponent<Renderer>().material.color = Color.blue;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().HighDSharp)){
			if(currentKey == key.HighDSharp){
				GetComponent<Renderer>().material.color = Color.black;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().HighE)){
			if(currentKey == key.HighE){
				GetComponent<Renderer>().material.color = Color.blue;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().HighE)){
			if(currentKey == key.HighE){
				GetComponent<Renderer>().material.color = Color.white;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().HighF)){
			if(currentKey == key.HighF){
				GetComponent<Renderer>().material.color = Color.blue;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().HighF)){
			if(currentKey == key.HighF){
				GetComponent<Renderer>().material.color = Color.white;
			}
		}
	}
}
