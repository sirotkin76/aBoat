using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMode : MonoBehaviour {

	public GameObject boat;
	public GameObject boatCamera;
	public GameObject player;
	public GameObject playerStartPosition;

	bool switches = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.E) && switches) {
			switches = !switches;
			// set to boat mode //
			boat.GetComponent<Rigidbody>().isKinematic = false;
			boat.GetComponent<BoatController>().enabled = true;
			boatCamera.SetActive(true);

			player.SetActive(false);
		} else if (Input.GetKeyDown(KeyCode.E) && !switches) {
			switches = !switches;
			// set to FPS mode //
			boat.GetComponent<Rigidbody>().isKinematic = true;
			boat.GetComponent<BoatController>().enabled = false;
			boatCamera.SetActive(false);

			player.SetActive(true);
			player.transform.position = playerStartPosition.transform.position;
		}

	}
}
