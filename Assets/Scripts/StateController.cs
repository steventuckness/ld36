using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StateController : MonoBehaviour {

    public int deadGenerals; 
    public int totalGeneralCount; 
    public bool isPlayerDead;

	// Use this for initialization
	void Start () {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
	}
	
	// Update is called once per frame
	void Update () {
		if (deadGenerals == totalGeneralCount || isPlayerDead) {
			this.LoadScene ("GameOver");
		}
	}

	public void LoadScene(string levelName)
	{
		SceneManager.LoadScene (levelName);
	}
}
