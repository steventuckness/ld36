using UnityEngine;
using System.Collections;

public class CanonballController : MonoBehaviour {

    public int damage = 10;

	DelayedDeathController delayedDeathController;

	void Start(){
		this.delayedDeathController = this.gameObject.GetComponent<DelayedDeathController> ();
	}

	void OnCollisionEnter(Collision col)
    {
        Damageable[] damageables = col.gameObject.GetComponents<Damageable>();
        foreach (Damageable d in damageables)
        {
            d.TakeDamage(damage);
        }

		delayedDeathController.BeginDieSlowly ();
    }
}
