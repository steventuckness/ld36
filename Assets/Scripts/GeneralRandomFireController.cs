using UnityEngine;
using System.Collections;

public class GeneralRandomFireController : MonoBehaviour {

    public GameObject cannonBall;
    public float cannonBallScale;
    public float power;
    public int chanceOfFire;
	public MonoBehaviour[] onFire;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        if (Mathf.RoundToInt(Random.value * chanceOfFire) == 1)
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
		cbc.cannonBallSource = "General";
	
		EventReceiverUtils.FireEvents (this, onFire);
    }
}
