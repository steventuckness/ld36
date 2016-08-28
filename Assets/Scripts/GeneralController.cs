using UnityEngine;
using System.Collections;

public class GeneralController : MonoBehaviour, Damageable {

	public int Health;

	//StateController stateController;

	public DelayedDeathController delayedDeathController;

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "Terrain" || Health > 0) {
			this.delayedDeathController.BeginDieSlowly ();
		} 
	}

	public void TakeDamage(int damage) {
		this.Health -= damage;
	}
				
	// Use this for initialization
	void Start () {
		//stateController = GameObject.Find ("State").GetComponent<StateController>();

		this.delayedDeathController = gameObject.GetComponent<DelayedDeathController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Health <= 0) {
			this.delayedDeathController.BeginDieSlowly ();
		}
	}
}
