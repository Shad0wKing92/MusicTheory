using UnityEngine;
using System.Collections;

public class ParticleScript : MonoBehaviour {

	public float lifetime;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Destroy (gameObject, lifetime);
	}
}
