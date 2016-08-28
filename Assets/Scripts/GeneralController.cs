using UnityEngine;
using System.Collections;

public class GeneralController : MonoBehaviour, Damageable {

	public int Health;

	public DelayedDeathController delayedDeathController;

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "Terrain") {
			this.delayedDeathController.BeginDieSlowly ();
		} 
	}

	public void TakeDamage(int damage) {
		this.Health -= damage;
	}
				
	// Use this for initialization
	void Start () {
		this.delayedDeathController = gameObject.GetComponent<DelayedDeathController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Health <= 0) {
			this.delayedDeathController.BeginDieSlowly ();
		}
	}
}
