using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	public float speed;
	public Rigidbody player1;
	public int score;
	public Text scoreDisplay;

	// Use this for initialization
	void Start () {
		player1 = GetComponent<Rigidbody> ();
		score = 0;
		scoreDisplay.text = "Score: " + score;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");



		Vector3 move = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		player1.AddForce (move * speed);
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Coin")) {
			other.gameObject.SetActive (false);
			score++;
			scoreDisplay.text = "Score: " + score;
		}
	}
}
