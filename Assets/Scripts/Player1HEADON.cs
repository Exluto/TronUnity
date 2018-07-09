using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1HEADON : MonoBehaviour {

	void OnCollisionEnter(Collision collision) {
		
		if(collision.transform.tag == "Player") {
			Destroy(collision.gameObject);
		}
	}
}
