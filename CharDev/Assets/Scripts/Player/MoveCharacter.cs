
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class MoveCharacter : MonoBehaviour {

	CharacterController cc;
	public PlayerData data;

	Vector3 tempMove;
//	public float speed = 7;
//	public float gravity = 0.8f;
//	public float jumpHeight = .2f;						this stuff is in the scriptable object
//	int jumpCount = 0;
//	int jumpNumber = 2;
	public GameObject Player;
	bool first = true;

	void Start () {
		cc = GetComponent<CharacterController>();
		Player.GetComponent<moveInput>().canPlay = true;
				moveInput.JumpAction = Jump;
		if(first == true){
		moveInput.KeyAction += Move;
		first = false;
		}
}


	void Jump(){
		if(data.jumpCount < data.jumpNumber){
			tempMove.y = data.jumpHeight;
			data.jumpCount ++;
		}
	}
	
	void Move (float _movement) {
		if( !cc.isGrounded)
		{tempMove.y -= data.gravity*Time.deltaTime;
		}
		tempMove.x = _movement*data.speed*Time.deltaTime;
		cc.Move(tempMove);
		
		if(cc.isGrounded){
			data.jumpCount = 0;
		}
	}
	

}
