using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monstar : MonoBehaviour {

	public PlayerMovements pm;

	public GameObject spwanLoc;

	void Start(){
		pm = GameObject.Find ("Player").GetComponent<PlayerMovements> ();
	}

	void OnTriggerEnter2D(){
		pm.deaths++;
		Debug.Log (pm.deaths);
		pm.rb.position = spwanLoc.transform.position;

	}

	void OnTriggerExit2D(){
		
	}
}
