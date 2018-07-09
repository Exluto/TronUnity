using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLose : MonoBehaviour {

	public GameObject _player;
	public GameObject _player1;

	void Start () {
		_player = GameObject.FindGameObjectWithTag("Player");
		_player1 = GameObject.FindGameObjectWithTag("Player1");
		
	}
	
	void Update () {
		Win();
		Lose();
		
	}

	void Win() {
		if(_player != null) {
			Debug.Log("player 1 wins");
		}
		if(_player1 != null) {
			Debug.Log("Player 2 wins");
		}
	}

	void Lose() {

		if(_player == null) {
			
		}
		if(_player1 == null) {

		}
	}
}
