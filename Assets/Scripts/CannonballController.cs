using UnityEngine;
using System.Collections;

public class CannonballController : MonoBehaviour {

    public int damage;
	public float magnitudeThreshold;

	public string cannonBallSource;

	void Start(){
		
	}

	void OnCollisionEnter(Collision col)
    {
        Damageable[] damageables = col.gameObject.GetComponents<Damageable>();
        foreach (Damageable d in damageables)
        {
			if (col.gameObject.tag == "Player" && this.cannonBallSource == "Player") {
				
			} else if (col.impulse.magnitude > magnitudeThreshold) {
				d.TakeDamage(damage);
			}
        }
    }
}
