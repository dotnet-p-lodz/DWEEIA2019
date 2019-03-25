using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagingScene : MonoBehaviour {

	private GameOver gOver;

	void Start(){
		gOver = GameObject.Find ("GameOver").GetComponent<GameOver> ();
	}

	void Update(){
		if (!gOver.playing && Input.GetKeyDown (KeyCode.Return))
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}
}
