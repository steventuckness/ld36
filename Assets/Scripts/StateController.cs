using UnityEngine;
using System.Collections;

public class StateController : MonoBehaviour {

    public int deadGenerals;
    public int totalGeneralCount;
    public bool isPlayerDead;

	// Use this for initialization
	void Start () {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
	}
	
	// Update is called once per frame
	void Update () {
        	
	}
}
