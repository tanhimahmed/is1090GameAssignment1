using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour {

	public Rigidbody coin;

	void Start () {
		for(int i = 0; i<50; i++){
			Rigidbody coinClone = (Rigidbody) Instantiate(coin, new Vector3(Random.Range(-9.0f, 9.0f), 0.6f, Random.Range(-9.0f, 9.0f)), transform.rotation);
			// Rigidbody coinClone = (Rigidbody) Instantiate(coin, transform.position, transform.rotation);
		}
	}
	

}
