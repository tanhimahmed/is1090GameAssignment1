using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;
	public Rigidbody player1;

	// Use this for initialization
	void Start () {
		player1 = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 move = new newVector3 (moveHorizontal, 0.0f, moveVertical);

		player1.AddForce (move * speed);
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.CompareTag("Coin")
			other.gameObject.SetActive(false);
	}
}
