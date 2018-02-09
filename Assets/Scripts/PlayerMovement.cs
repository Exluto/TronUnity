using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public KeyCode upKey;
	public KeyCode downKey;
	public KeyCode rightKey;
	public KeyCode leftKey;
	private float m_speed = 16;
	public Rigidbody2D m_rb;
	public GameObject m_wallprefab;
	Collider2D m_wall;
	void Start () {
		m_rb=GetComponent<Rigidbody2D>();
	}
	void Wall() {
		GameObject g = (GameObject)Instantiate(m_wallprefab, transform.position, Quaternion.identity);
		m_wall = GetComponent<Collider2D>();
	}
	void Update () {
		if(Input.GetKeyDown(downKey)) {
			m_rb.velocity = Vector2.down * m_speed;

		} else if (Input.GetKeyDown(upKey)) {
			m_rb.velocity = Vector2.up * m_speed;

		} else if (Input.GetKeyDown(rightKey)) {
			m_rb.velocity = Vector2.right * m_speed;

		} else if (Input.GetKeyDown(leftKey)) {
			m_rb.velocity = Vector2.left * m_speed;

		}
		
	}
}
