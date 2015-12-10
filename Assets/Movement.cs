using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public GameObject LeftButton;
	public GameObject RightButton;
	public GameObject Player;

	public bool isLeft;
	public bool isRight;

	public int Speed;
	public int RotationSpeed; //Even though we don't need rotation lol

	void OnMouseDown() {
		while (isLeft) {
			/*if (isLeft || Input.GetKeyDown (KeyCode.A)) {*/
				GetComponent<Renderer> ().material.color = Color.blue;
				MoveLeft ();
			//} 
		}

		if (isRight /*|| Input.GetKeyDown(KeyCode.D)*/) {
			GetComponent<Renderer> ().material.color = Color.blue;
			MoveRight();
		} 

	}

	void OnMouseUp() {
		if (isLeft) {
			GetComponent<Renderer> ().material.color = Color.white;
		}

		if (isRight) {
			GetComponent<Renderer> ().material.color = Color.white;
		}
	}

	void MoveLeft() {
		Player.GetComponent<Rigidbody> ().transform.Translate (Vector3.left * Speed * Time.deltaTime, Space.World);
	}

	void MoveRight() {

	}

}
