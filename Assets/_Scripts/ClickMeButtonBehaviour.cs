using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickMeButtonBehaviour : MonoBehaviour {

	// Public Instance Variables
	public Button ClickMeButton;
	public Text HelloWorldLabel;

	// Use this for initialization
	void Start () {
		this.ClickMeButton.onClick.AddListener (this.ClickHandler);
	}

	// Click event handler
	public void ClickHandler() {
		this.HelloWorldLabel.text = "Clicked!";
	}

}
