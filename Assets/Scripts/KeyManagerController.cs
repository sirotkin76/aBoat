using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyManagerController : MonoBehaviour {

	public KeyCode exitGame;

	private Text text;

	void Start() {
		text = this.GetComponentInChildren<Text>();
		text.text = "Переключиться - Е; " + " Выход - " + exitGame.ToString() + "; ";

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(exitGame))
			Application.Quit();

	}
}
