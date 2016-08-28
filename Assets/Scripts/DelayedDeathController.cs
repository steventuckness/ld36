using UnityEngine;
using System.Collections;

public class DelayedDeathController : MonoBehaviour {

	public int ActiveSetToFalseDelay;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void BeginDieSlowly() {
		StartCoroutine (DieSlowly ());
	}

	IEnumerator DieSlowly() {
		yield return new WaitForSeconds(ActiveSetToFalseDelay);
		this.gameObject.SetActive(false);
	}
}
