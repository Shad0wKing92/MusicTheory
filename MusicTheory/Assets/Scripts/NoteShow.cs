using UnityEngine;
using System.Collections;

public class NoteShow : MonoBehaviour {

	public GameObject KeyCodeIndex;
	public GameObject notes;
	public string keyName;
	public enum key {MiddleC, CSharp, D, DSharp, E, F, FSharp, G, GSharp, A, ASharp, B, HighC, HighCSharp, HighD, HighDSharp, HighE, HighF};
	key currentKey;

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Renderer>().enabled = false;
		GetComponent<Renderer>().material.color = Color.blue;
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
				gameObject.GetComponent<Renderer>().enabled = true;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().MiddleC)){
			if(currentKey == key.MiddleC){
				gameObject.GetComponent<Renderer>().enabled = false;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().CSharp)){
			if(currentKey == key.CSharp){
				gameObject.GetComponent<Renderer>().enabled = true;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().CSharp)){
			if(currentKey == key.CSharp){
				gameObject.GetComponent<Renderer>().enabled = false;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().D)){
			if(currentKey == key.D){
				gameObject.GetComponent<Renderer>().enabled = true;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().D)){
			if(currentKey == key.D){
				gameObject.GetComponent<Renderer>().enabled = false;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().DSharp)){
			if(currentKey == key.DSharp){
				gameObject.GetComponent<Renderer>().enabled = true;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().DSharp)){
			if(currentKey == key.DSharp){
				gameObject.GetComponent<Renderer>().enabled = false;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().E)){
			if(currentKey == key.E){
				gameObject.GetComponent<Renderer>().enabled = true;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().E)){
			if(currentKey == key.E){
				gameObject.GetComponent<Renderer>().enabled = false;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().F)){
			if(currentKey == key.F){
				gameObject.GetComponent<Renderer>().enabled = true;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().F)){
			if(currentKey == key.F){
				gameObject.GetComponent<Renderer>().enabled = false;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().FSharp)){
			if(currentKey == key.FSharp){
				gameObject.GetComponent<Renderer>().enabled = true;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().FSharp)){
			if(currentKey == key.FSharp){
				gameObject.GetComponent<Renderer>().enabled = false;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().G)){
			if(currentKey == key.G){
				gameObject.GetComponent<Renderer>().enabled = true;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().G)){
			if(currentKey == key.G){
				gameObject.GetComponent<Renderer>().enabled = false;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().GSharp)){
			if(currentKey == key.GSharp){
				gameObject.GetComponent<Renderer>().enabled = true;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().GSharp)){
			if(currentKey == key.GSharp){
				gameObject.GetComponent<Renderer>().enabled = false;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().A)){
			if(currentKey == key.A){
				gameObject.GetComponent<Renderer>().enabled = true;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().A)){
			if(currentKey == key.A){
				gameObject.GetComponent<Renderer>().enabled = false;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().ASharp)){
			if(currentKey == key.ASharp){
				gameObject.GetComponent<Renderer>().enabled = true;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().ASharp)){
			if(currentKey == key.ASharp){
				gameObject.GetComponent<Renderer>().enabled = false;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().B)){
			if(currentKey == key.B){
				gameObject.GetComponent<Renderer>().enabled = true;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().B)){
			if(currentKey == key.B){
				gameObject.GetComponent<Renderer>().enabled = false;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().HighC)){
			if(currentKey == key.HighC){
				gameObject.GetComponent<Renderer>().enabled = true;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().HighC)){
			if(currentKey == key.HighC){
				gameObject.GetComponent<Renderer>().enabled = false;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().HighCSharp)){
			if(currentKey == key.HighCSharp){
				gameObject.GetComponent<Renderer>().enabled = true;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().HighCSharp)){
			if(currentKey == key.HighCSharp){
				gameObject.GetComponent<Renderer>().enabled = false;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().HighD)){
			if(currentKey == key.HighD){
				gameObject.GetComponent<Renderer>().enabled = true;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().HighD)){
			if(currentKey == key.HighD){
				gameObject.GetComponent<Renderer>().enabled = false;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().HighDSharp)){
			if(currentKey == key.HighDSharp){
				gameObject.GetComponent<Renderer>().enabled = true;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().HighDSharp)){
			if(currentKey == key.HighDSharp){
				gameObject.GetComponent<Renderer>().enabled = false;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().HighE)){
			if(currentKey == key.HighE){
				gameObject.GetComponent<Renderer>().enabled = true;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().HighE)){
			if(currentKey == key.HighE){
				gameObject.GetComponent<Renderer>().enabled = false;
			}
		}
		if(Input.GetKeyDown(KeyCodeIndex.GetComponent<KeyManager>().HighF)){
			if(currentKey == key.HighF){
				gameObject.GetComponent<Renderer>().enabled = true;
			}
		}
		if(Input.GetKeyUp(KeyCodeIndex.GetComponent<KeyManager>().HighF)){
			if(currentKey == key.HighF){
				gameObject.GetComponent<Renderer>().enabled = false;
			}
		}
	}
}
