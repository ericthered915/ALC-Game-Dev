using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {
	public class CheckPoint : MonoBehaviour {

		public LevelManager levelManager;

	// Use this for initialization
	void Start () {
			levelManger = FindObjectOfType <levelManager> ();
		
	}
	
	// Update is called once per frame
	void Update () {

	void On TriggerEnter2D(Collider2D other){
				if(other.name == "Player"){
					levelManager.currentCheckPoint = gameObject;
					Debug.Log ("Activated CheckPoint" + transform.Position);
				}
			

		
	}
}
