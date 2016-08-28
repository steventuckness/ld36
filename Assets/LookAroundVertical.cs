using UnityEngine;
using System.Collections;

public class LookAroundVertical : MonoBehaviour {

    public Transform target;
    public Transform pivot;
    public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        Vector3 direction = target.transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        RotateAroundPoint(transform, pivot, Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * speed));
    }

    // returns the source rotated around pivot
    static Transform RotateAroundPoint(Transform source, Transform pivot, Quaternion angle ) {
        Vector3 originalPosition = source.position;
        source.position = pivot.position;
        source.rotation = angle;
        source.position = originalPosition;
        return source; 
    }
}
