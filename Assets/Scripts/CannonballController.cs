using UnityEngine;
using System.Collections;

public class CannonballController : MonoBehaviour {

    public int damage = 10;

	public string cannonBallSource;

	void Start(){
		
	}

	void OnCollisionEnter(Collision col)
    {
        Damageable[] damageables = col.gameObject.GetComponents<Damageable>();
        foreach (Damageable d in damageables)
        {
			if (col.gameObject.tag == "Player" && this.cannonBallSource == "Player") {
				
			} else {
				d.TakeDamage(damage);
			}
        }
    }
}
