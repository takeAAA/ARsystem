using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour {

	public void Select1 () {
		SceneManager.LoadScene("Scenes/test");
	}
	
	public void Select2 () {
		SceneManager.LoadScene("Scenes/Vuforia-3-VideoPlayback");
	}

	public void Select3 () {
		SceneManager.LoadScene("Scenes/main");
	}
}
