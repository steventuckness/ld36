using UnityEngine;
using System.Collections;

public class CannonAimController : MonoBehaviour {

    private Vector3 previousMousePos;
    public float movementMultiplier;

	// Use this for initialization
	void Start () {
        previousMousePos = Input.mousePosition;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 curPos = Input.mousePosition;
        float delta = curPos.y - previousMousePos.y;
        Vector3 pivot = transform.Find("CannonPivot").position;
        //transform.Rotate(Vector3.forward * delta * movementMultiplier);
        transform.RotateAround(pivot, Vector3.left, delta * movementMultiplier);
        previousMousePos = curPos;
	}

}
