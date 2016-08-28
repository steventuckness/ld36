using UnityEngine;
using System.Collections;

public class LookAtHorizontal : MonoBehaviour {

    public GameObject player;
    public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

    void FixedUpdate()
    {
        Vector3 zxMask = new Vector3(1, 0, 1);
        Vector3 direction = Vector3.Scale(player.transform.position - transform.position, zxMask);
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * speed);
    }
}
