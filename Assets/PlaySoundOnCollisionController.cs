using UnityEngine;
using System.Collections;
using System.Linq;

public class PlaySoundOnCollisionController : MonoBehaviour {

	public AudioSource audioSource;
	public AudioClip[] clips;
	public string[] collisionTags;
	public int chanceOfPlaying;

	void OnCollisionEnter(Collision col) {
		if (collisionTags.Contains (col.gameObject.tag)) {
			//if (Mathf.RoundToInt(Random.Range (1, chanceOfPlaying)) == 1) {

			audioSource.clip = clips [Mathf.RoundToInt (Random.Range (0, clips.Length))];
			audioSource.Play ();
			//}
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
