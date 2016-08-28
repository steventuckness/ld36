using UnityEngine;
using System.Collections;

public class BackgroundMusicController : MonoBehaviour {

	public AudioSource audio;
	static bool isPlaying = false;
	static AudioSource currentSource;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Awake() {
		if (isPlaying)
			return;

		currentSource = audio;
		audio.Play ();
		DontDestroyOnLoad (gameObject);
		isPlaying = true;
	}

	public static void StopMusic() {
		if (!currentSource)
			return;

		isPlaying = false;
		currentSource.Stop ();
	}
}
