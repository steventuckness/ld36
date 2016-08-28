using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StateController : MonoBehaviour {

    public int deadGenerals; 
    public int totalGeneralCount; 
    public bool isPlayerDead;
	private float sceneChangeTime;
	private bool loadGameOver;
	private bool reload;

	// Use this for initialization
	void Start () {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
		loadGameOver = false;
		reload = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (isPlayerDead && !loadGameOver && !reload) {
			Reload ();
		}

		if (deadGenerals == totalGeneralCount && !loadGameOver && !reload) {
			LoadGameOver();
		}

		if (loadGameOver && (Time.time - sceneChangeTime) > 3) {
			LoadScene ("GameOver");
		}
		if (reload && (Time.time - sceneChangeTime) > 3) {
			LoadScene ("MainGame");
		}
	}

	void LoadGameOver() {
		loadGameOver = true;
		sceneChangeTime = Time.time;
	}

	void Reload() {
		reload = true;
		sceneChangeTime = Time.time;
	}

	public void LoadScene(string levelName)
	{
		SceneManager.LoadScene (levelName);
	}
}
