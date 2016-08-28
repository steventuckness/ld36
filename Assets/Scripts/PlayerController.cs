using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour, Damageable {

	public int Health;
	public GameObject deathExplosion;

	public StateController stateController;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Health <= 0) {
			Die ();
		}
	}

	public void TakeDamage(int damage){
		Health -= damage;
	}

	void Die() {
		Instantiate (deathExplosion, transform.position, transform.rotation);
		gameObject.SetActive (false);
		stateController.isPlayerDead = true;
	}
}
