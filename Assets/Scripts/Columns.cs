﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Columns : MonoBehaviour {
	private void OnTriggerEnter2D (Collider2D other){ 
		Debug.Log ("ColTrig");

		if (other.GetComponent<Bird>() != null){
			GameControl.instance.BirdScored ();
		}

	}
}
