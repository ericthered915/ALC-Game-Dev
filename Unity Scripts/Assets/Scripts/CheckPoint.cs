using System.Collections;
using System.Collections.Generic;
using UnityEngine;


	public class CheckPoint : MonoBehaviour {

		public LevelManager levelManager;

	// Use this for initialization
	void Start () {
			levelManager = FindObjectOfType <LevelManager> ();
		
	}
	
	

	private void OnTriggerEnter2D(Collider2D other){
				if(other.name == "Player"){
					levelManager.CurrentCheckPoint = gameObject;
					Debug.Log ("Activated CheckPoint" + transform.position);
				}
			

		
	}
}
