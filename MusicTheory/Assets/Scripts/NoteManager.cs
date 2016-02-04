using UnityEngine;
using System.Collections;

public class NoteManager : MonoBehaviour {
	
	private int attackPower;
	private int enemyAttackPower;
	int tempAttack;
	int enemyAttackTemp;

	public float speed;

	private PlayerScript PS;
	private EnemyScript ES;
	private NoteSpawner NS;

	public GUIText playerDamage;
	public GUIText enemyDamage;

//	private NoteMovement NM;
//	private MeasureBarMovement MBM;

	public float SpeedUpSpeed;

	public int timer;

	// Use this for initialization
	void Start () {
		PS = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerScript> ();
		ES = GameObject.FindGameObjectWithTag ("Enemy").GetComponent<EnemyScript> ();
		NS = GameObject.FindGameObjectWithTag ("Spawner").GetComponent<NoteSpawner> ();
		//NM = GameObject.FindGameObjectWithTag ("Note").GetComponent<NoteMovement> ();
		//MBM = GameObject.FindGameObjectWithTag ("MeasureBar").GetComponent<MeasureBarMovement> ();
		playerDamage.enabled = false;
		enemyDamage.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(PS.dead){
			playerDamage.GetComponent<GUIText>().enabled = false;
		}
		if(ES.enemyDead){
			enemyDamage.GetComponent<GUIText>().enabled = false;
		}
//		if (enemyAttackPower == 5) {
//			SpeedUp();
//		}
	}

	public void AddAttackPowerPlayer(){
		if(!PS.dead){
			attackPower++;
		}
	}

	public void AddAttackPowerEnemy(){
		if(!ES.enemyDead){
			enemyAttackPower++;
		}
	}

	public void UnleashAttack(){
		PS.Health -= enemyAttackPower;
		ES.enemyHealth -= attackPower;
		StartCoroutine(GUIDamage());
		attackPower = 0;
		enemyAttackPower = 0;
	}

	public void spawnSong(int number){
		Instantiate (NS.NoteList [number], new Vector3 (12f, NS.Note.GetComponent<NoteMovement> ().Yposition, -0.5f), transform.rotation);	
	}

//	void SpeedUp(){
//		NM.NoteSpeed = SpeedUpSpeed;
//		MBM.BarSpeed = SpeedUpSpeed;
//	}

	void OnGUI(){
		GUI.Label (new Rect (10, 535, 150, 100), ("Player Attack Power: " + attackPower));
		GUI.Label (new Rect (10, 550, 150, 100), ("Enemy Attack Power: " + enemyAttackPower));
		playerDamage.text = ("-" + enemyAttackTemp);
		enemyDamage.text = ("-" + tempAttack);
	}

	IEnumerator GUIDamage(){
		tempAttack = attackPower;
		enemyAttackTemp = enemyAttackPower;
		playerDamage.enabled = true;
		enemyDamage.enabled = true;
		yield return new WaitForSeconds(3f);
		playerDamage.enabled = false;
		enemyDamage.enabled = false;
	}

}
