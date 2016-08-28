using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StateController : MonoBehaviour {

    public int deadGenerals; 
    public int totalGeneralCount; 
    public bool isPlayerDead;
	private float sceneChangeTime;
	private bool loadGameOver;

	// Use this for initialization
	void Start () {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
		loadGameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (isPlayerDead && !loadGameOver) {
			LoadGameOver ();
		}

		if (deadGenerals == totalGeneralCount && !loadGameOver) {
			LoadGameOver ();
		}

		if (loadGameOver && (Time.time - sceneChangeTime) > 3) {
			LoadScene ("GameOver");
		}
	}

	void LoadGameOver() {
		loadGameOver = true;
		sceneChangeTime = Time.time;
	}

	public void LoadScene(string levelName)
	{
		SceneManager.LoadScene (levelName);
	}
}
