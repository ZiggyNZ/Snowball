﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Camera : MonoBehaviour {
	private Transform player;
	private Camera camera;
	private float zoom;

	void Start () {
		this.player = GameObject.FindWithTag("Player2").transform;
		this.camera = GetComponent<Camera>();
		this.zoom = 10f;
	}
	
	void Update () {
		if(Input.GetKey(KeyCode.U) && zoom < 15f) {
			zoom += 0.1f;

		} else if(Input.GetKey(KeyCode.O) && zoom > 5f) {
			zoom -= 0.1f;
		}

		//Move camera to 135deg x 45deg from the player. (Is watching over the right shoulder)
		camera.transform.position = new Vector3(
			player.position.x - zoom,
			player.position.y + zoom + 1,
			player.position.z - zoom);
	}
}
