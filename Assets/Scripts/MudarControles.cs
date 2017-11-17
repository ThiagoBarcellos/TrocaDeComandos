using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudarControles : MonoBehaviour {

	//public KeyCode[] controllers = {KeyCode.A, KeyCode.D, KeyCode.W, KeyCode.S, KeyCode.LeftArrow, KeyCode.RightArrow, KeyCode.UpArrow, KeyCode.DownArrow};

	public KeyCode jumpKey;
	public KeyCode leftKey;
	public KeyCode rightKey;
	public KeyCode downKey;

	// Use this for initialization
	void Start () {
		
	}

	public bool IsJumpDown(){
		return Input.GetKeyDown (jumpKey);
	}
	public bool IsCrouching(){
		return Input.GetKey (downKey);
	}
	public bool IsMovingLeft(){
		return Input.GetKey (leftKey);
	}
	public bool IsMovingRight(){
		return Input.GetKey (rightKey);
	}
	// Update is called once per frame
	void Update () {

	}
}