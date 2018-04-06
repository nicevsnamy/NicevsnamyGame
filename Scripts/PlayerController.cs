using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float PlayerSpeed;

	void Start(){
		
	}
	void Update () {
		float moveHorizontal = Input.GetAxis ("Horizontal") * PlayerSpeed * Time.deltaTime;
		float moveVertical = Input.GetAxis ("Vertical") * PlayerSpeed * Time.deltaTime;

		transform.Translate (new Vector3 (moveHorizontal, moveVertical));
	}﻿
}