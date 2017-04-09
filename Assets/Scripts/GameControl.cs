using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameControl : MonoBehaviour
{
	public AudioSource scoreSound;
	public AudioSource dieSound;
	public static GameControl instance;
	public Text scoreText;
	public GameObject gameOverText;
	public bool gameOver = false;
	public float scrollSpeed = -1.5f;
	private int score = 0;
	// Use this for initialization
	public void Awake ()
	{
		//Debug.Log("GC.Awake()");

		if (instance == null) {
			instance = this;

		} else if (instance != this) {
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		//scoreText.
		if (gameOver == true && Input.GetMouseButtonDown (0)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}

		
	}

	public void BirdScored (){
		//Debug.Log ("Score");

		if (!gameOver) {
			scoreSound.Play();

			score++;
			scoreText.text = "score:" + score.ToString ();
		}
	}
	public void BirdDied ()
	{
		dieSound.Play();
		gameOverText.SetActive (true);
		gameOver = true;	
	}

}


