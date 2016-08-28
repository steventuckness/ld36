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
        Transform pivot = transform.Find("CannonPivot"); 
        transform.RotateAround(pivot.position, pivot.forward, delta * movementMultiplier);
        previousMousePos = curPos;
	}

}
