using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;
	public float turnSpeed;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
		player = player;
	}

	// Update is called once per frame
	void Update () {
	}

	void FixedUpdate(){
		
	}

	void LateUpdate ()
	{
		if (Input.GetButtonDown ("CameraRight")) {
			offset = Quaternion.AngleAxis (90, Vector3.down) * offset;
			transform.position = player.transform.position + offset;
			transform.LookAt (player.transform.position);
			offset = transform.position - player.transform.position;
		} 

		transform.position = player.transform.position + offset;

		if (Input.GetButtonDown ("CameraLeft")) {
			offset = Quaternion.AngleAxis (-90, Vector3.down) * offset;
			transform.position = player.transform.position + offset;
			transform.LookAt (player.transform.position);
			offset = transform.position - player.transform.position;
		} 

		transform.position = player.transform.position + offset;
	}
}
