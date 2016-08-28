using UnityEngine;
using System.Collections;

public class GeneralController : MonoBehaviour, Damageable {

	public int Health;
	public GameObject deathExplosion;
	public StateController state;


	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "Terrain") {
			Die ();
		} 
	}

	public void TakeDamage(int damage) {
		this.Health -= damage;
	}
				
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Health <= 0) {
			Die ();
		}
	}

	void Die() {
		Instantiate (deathExplosion, transform.position, transform.rotation);
		gameObject.SetActive (false);
		state.deadGenerals++;
	}
}
