using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour, Damageable {

	public int Health;
	public GameObject deathExplosion;
	public Slider healthSlider;

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
		healthSlider.value = Health;
	}

	void Die() {
		Instantiate (deathExplosion, transform.position, transform.rotation);
		gameObject.SetActive (false);
		stateController.isPlayerDead = true;
	}
}
