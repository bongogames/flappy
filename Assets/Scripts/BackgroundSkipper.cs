using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSkipper : MonoBehaviour {
	private BoxCollider2D background;
	private float width;

	// Use this for initialization
	void Start () {
		background = GetComponent<BoxCollider2D> ();
		width = background.size.x;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < -width) {
			Vector2 change = new Vector2 (width * 2 , 0);
			transform.position = (Vector2)transform.position + change;
		}
	}
}
