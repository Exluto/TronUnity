﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHEADON : MonoBehaviour {

	void OnCollisionEnter(Collision collision) {
		
		if(collision.transform.tag == "Player1") {
			Destroy(collision.gameObject);
		}
	}
}
