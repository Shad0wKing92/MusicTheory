using UnityEngine;
using System.Collections;

public class SoundManagerScript : MonoBehaviour {

	public AudioSource MiddleC;
	public AudioSource CSharp;
	public AudioSource D;
	public AudioSource DSharp;
	public AudioSource E;
	public AudioSource F;
	public AudioSource FSharp;
	public AudioSource G;
	public AudioSource GSharp;
	public AudioSource A;
	public AudioSource ASharp;
	public AudioSource B;
	public AudioSource HighC;
	public AudioSource HighCSharp;
	public AudioSource HighD;
	public AudioSource HighDSharp;
	public AudioSource HighE;
	public AudioSource HighF;

//	public AudioClip MiddleCClip;
//	public AudioClip CSharpClip;
//	public AudioClip DClip;
//	public AudioClip DSharpClip;
//	public AudioClip EClip;
//	public AudioClip FClip;
//	public AudioClip FSharpClip;
//	public AudioClip GClip;
//	public AudioClip GSharpClip;
//	public AudioClip AClip;
//	public AudioClip ASharpClip;
//	public AudioClip BClip;
//	public AudioClip HighCClip;
//	public AudioClip HighCSharpClip;
//	public AudioClip HighDClip;
//	public AudioClip HighDSharpClip;
//	public AudioClip HighEClip;
//	public AudioClip HighFClip;

	static private SoundManagerScript instance;

	static public SoundManagerScript Instance{
		get { return instance;}
	}

	void Awake(){
		if (instance != null && instance != this) {
			Destroy (gameObject);
		} else {
			instance = this;
		}

		DontDestroyOnLoad (gameObject);
	}
}
