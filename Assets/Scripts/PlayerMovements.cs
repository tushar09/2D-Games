using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour {

	public float moveSpeed = 10f;
	public float jumpSpeed = 10f;
	public float tempSpeed;
	public float accSpeed = 15f;

	public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		tempSpeed = moveSpeed;
		accSpeed = 15f;
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log ("speed " + moveSpeed);

		//left
		if(Input.GetKey(KeyCode.A)){
			rb.velocity = new Vector2 (-moveSpeed, rb.velocity.y);
		}
		//left stop
		if(Input.GetKeyUp(KeyCode.A)){
			rb.velocity = new Vector2 (0, rb.velocity.y);
		}


		//Right
		if(Input.GetKey(KeyCode.D)){
			rb.velocity = new Vector2 (moveSpeed, rb.velocity.y);
		}
		//left stop
		if(Input.GetKeyUp(KeyCode.D)){
			rb.velocity = new Vector2 (0, rb.velocity.y);
		}


		//run
		if(Input.GetKey(KeyCode.LeftShift)){
			Debug.Log ("asdf" + moveSpeed);
			if (moveSpeed < accSpeed) {
				moveSpeed += accSpeed / 120;
			} else {
				Debug.Log ("smaller " + moveSpeed + " " + accSpeed);
			}
		}
		//left stop
		if(Input.GetKeyUp(KeyCode.LeftShift)){
			moveSpeed = tempSpeed;
		}
	}
}
