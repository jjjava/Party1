using UnityEngine;
using System.Collections;

public class BladeMovement : MonoBehaviour {

	public int speed;
	void Start () {
		speed = 1;
	}

	void Update () {
		transform.Rotate(0,speed*Time.deltaTime,0);
		speed++;
	}
}
