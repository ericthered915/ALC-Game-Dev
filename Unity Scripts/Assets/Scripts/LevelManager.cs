using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
	public GameObject currentCheckPoint;
	private Rigidbody2D Player;

	//Particles
	public GameObject deathParticle;
	public GameObject respawnParicle;

	//Respawn Delay
	public float respawnDelay;

	//Point Penalty on Death
	public int PointPenaltyOnDeath;

	// Store Gravity Value
	private float gravityStore;

	// Use this for initialization
	void Start () {
		Player = FindObjectOfType<RididBody2D> ();
	}

	public void RespawnPlayer(){
		StartCoroutine ("RespawnPlayerCo");
	}

	public IEnumerator RespawnPlayerCo(){
		//Generate Death Particle
		Instantiate (deathParticle, Player.transform.position, Player.transform.rotation);
		//HidePlayer
		Player.GetComponent<Renderer> ().enabled = false;
		// Gravity Reset
		gravityStore = Player.GetComponent<Rigidbody2D> ().gravityScale;
		Player.GetComponent<Rigidbody2D> ().gravityScale = 0f;
		Player.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
		// Point Penalty
		ScoreManager.AddPoints (-PointPenaltyOnDeath);
		//Debug Message
		Debug.Log ("Player Respawn");
		//Respawn Delay
		yield return new WaitForSeconds (respawnDelay);
		//Gravity Restore
		Player.GetComponent<Rigidbody2D> ().gravityScale = gravityStore;
		//Match Players transform position
		Player.transform.position = currentCheckPoint.transform.position;
		//ShowPlayer
		//Player.enabled = true;
		Player.GetComponent<Renderer> ().enabled = true;

		//Spawn Player
		Instantiate (RespawnParticle, CurrentCheckPoint.transform.position, CurrentCheckpoint.transform.rotation);
	




		
	}
	

		
	}

