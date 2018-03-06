using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PlayerData")]

public class PlayerData : ScriptableObject {

	public float speed;
	public float gravity;
	public float jumpHeight;
	public int jumpCount;
	public int jumpNumber;


}
