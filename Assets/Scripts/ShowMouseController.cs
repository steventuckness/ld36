using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ShowMouseController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
	}

	public void LoadScene(string scene) {
		SceneManager.LoadScene (scene);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
