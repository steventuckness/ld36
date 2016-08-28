using UnityEngine;
using System.Collections;

public class PlaySoundsOnEventController : MonoBehaviour , EventReceiver {

	public AudioSource audioSource;
	public AudioClip[] clips;

	public void ReceiveEvent (MonoBehaviour source) {
		audioSource.clip = clips [Mathf.RoundToInt (Random.Range (0, clips.Length))];
		audioSource.Play ();
	}
}
