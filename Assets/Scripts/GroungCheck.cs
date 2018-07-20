using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroungCheck : MonoBehaviour {
	
	void OnTriggerEnter2D(){
		PlayerMovements.canJump = true;
	}

	void OnTriggerExit2D(){
		PlayerMovements.canJump = false;
	}
}
