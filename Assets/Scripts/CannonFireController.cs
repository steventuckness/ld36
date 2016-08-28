using UnityEngine;
using System.Collections;

public class CannonFireController : MonoBehaviour {

    public GameObject cannonBall;
	public MonoBehaviour[] onFire;
    public float cannonBallScale;
    public float power;
    public int cooldown;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }	
	}

    void Fire()
    {
        GameObject ball = Instantiate(cannonBall, transform.position, transform.rotation) as GameObject;
		Rigidbody ballRB = ball.GetComponent<Rigidbody>();
        Transform tip = transform.Find("CannonTip").transform;
        ball.transform.localScale -= new Vector3(cannonBallScale, cannonBallScale, cannonBallScale);
        ballRB.position = tip.position;
        ballRB.velocity = tip.transform.right * -1 * power;
		CannonballController cbc = ball.GetComponent<CannonballController> ();
		cbc.cannonBallSource = "Player";
		EventReceiverUtils.FireEvents (this, onFire);
    }
}
