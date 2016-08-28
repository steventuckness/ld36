using UnityEngine;
using System.Collections;

public class CannonMovementController : MonoBehaviour {


    HORIZONTAL_DIRECTION curHorizontalDirection;
    FORWARD_DIRECTION curForwardDirection;

    public float horizontalMovementSensitivity = 1.0f;
    public float acceleration = 10.0f;
    
    enum HORIZONTAL_DIRECTION
    {
        LEFT, RIGHT, NONE
    }

    enum FORWARD_DIRECTION
    {
        FORWARD, BACKWARD, NONE
    }

	// Use this for initialization
	void Start () {
        curHorizontalDirection = HORIZONTAL_DIRECTION.NONE;
        curForwardDirection = FORWARD_DIRECTION.NONE;
	}
	
    void FixedUpdate()
    {
        MoveForward();
    }

	// Update is called once per frame
	void Update () {
        DetectHorizontalDirection();
        DetectForwardDirection();
        Rotate();
	}

    void DetectForwardDirection()
    {
        if ((Input.GetKeyUp("w") && curForwardDirection == FORWARD_DIRECTION.FORWARD)
            || (Input.GetKeyUp("s") && curForwardDirection == FORWARD_DIRECTION.BACKWARD))
        {
            curForwardDirection = FORWARD_DIRECTION.NONE;
        }

        if (Input.GetKeyDown("w"))
        {
            curForwardDirection = FORWARD_DIRECTION.FORWARD;             
        }        
        if (Input.GetKeyDown("s"))
        {
            curForwardDirection = FORWARD_DIRECTION.BACKWARD;
        }        
        
    }

    void MoveForward()
    {
        float direction = 0f;
        Rigidbody rb = GetComponent<Rigidbody>();
        if (curForwardDirection == FORWARD_DIRECTION.NONE)
        {
            return;
        }
        if (curForwardDirection == FORWARD_DIRECTION.FORWARD)
        {
            direction = 1;
        }
        else if (curForwardDirection == FORWARD_DIRECTION.BACKWARD)
        {
            direction = -1;
        }
        rb.AddForce(transform.forward * direction * acceleration);
    }

    void DetectHorizontalDirection()
    {

        if ((Input.GetKeyUp("a") && curHorizontalDirection == HORIZONTAL_DIRECTION.LEFT)
            || (Input.GetKeyUp("d") && curHorizontalDirection == HORIZONTAL_DIRECTION.RIGHT))
        {
            curHorizontalDirection = HORIZONTAL_DIRECTION.NONE;
        }
        if (Input.GetKeyDown("a"))
        {
            curHorizontalDirection = HORIZONTAL_DIRECTION.LEFT;
        }
        else if (Input.GetKeyDown("d"))
        {
            curHorizontalDirection = HORIZONTAL_DIRECTION.RIGHT; 
        }
    }

    void Rotate()
    {
        float direction = 0;

        if (curHorizontalDirection == HORIZONTAL_DIRECTION.NONE)
        {
            return;
        }

        if (curHorizontalDirection == HORIZONTAL_DIRECTION.LEFT)
        {
            direction = -1; 
        }
        else
        {
            direction = 1;
        }

        Vector3 pivot = transform.Find("MovementPivot").position;
        transform.RotateAround(pivot, Vector3.up, direction * Time.deltaTime * horizontalMovementSensitivity);
    }


}
