using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour {

	void OnCollisionEnter(Collision collision) {
		if(collision.transform.tag == "Player") {
			Destroy(collision.gameObject);

		} else if(collision.transform.tag == "Player1") {
			Destroy(collision.gameObject);
		}
	}
}
