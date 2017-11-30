using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movemensInvaders : MonoBehaviour {

	public float speed = 1f;
	public bool inverso;
	public float max;
	public float min;

	void Start () {
		inverso = false;
	}


	void Update () {
		

		Vector3 movement = new Vector3(1, 0, 0);
		movement = movement.normalized * ((inverso)? speed * -1 :speed) * Time.deltaTime;
		transform.Translate(movement);
		
	}
}
