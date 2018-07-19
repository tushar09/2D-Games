using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour {

	public float moveSpeed = 10;
	public float jumpSpeed = 10;
	public float tempSpeed;
	public float accSpeed;

	public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {

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
	}
}
