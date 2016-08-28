using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour, Damageable {

	public int Health;

	public StateController stateController;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Health <= 0) {
			stateController.LoadScene ("GameOver");
		}
	}

	public void TakeDamage(int damage){
		Health -= damage;
	}
}
