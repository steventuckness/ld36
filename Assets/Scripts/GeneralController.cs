using UnityEngine;
using System.Collections;

public class GeneralController : MonoBehaviour {

	public bool Alive = true;

	StateController stateController;

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "Terrain" && this.Alive == true) {
			this.Alive = false;
			this.stateController.deadGenerals++;
			this.gameObject.SetActive(false);
		}
	}


	// Use this for initialization
	void Start () {
		stateController = GameObject.Find ("State").GetComponent<StateController>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
