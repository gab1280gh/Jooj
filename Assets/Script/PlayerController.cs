using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody cubinho;
	private GameObject NPCConversa;
	public float jump;
	Vector3 forward, right;
	private bool isFalling = false;
	float vel = 2f;
	float turnSpeed = 100f;
	Quaternion facing;
	public float fallMultiplier = 2.5f;
	public float lowJumpMultiplier = 2f;

	// Use this for initialization
	void Start () {

		cubinho = GetComponent<Rigidbody> ();
		jump = 30f;

	}
	
	// Update is called once per frame
	void Update () {

		Vector3 direction = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		Vector3 rightMove = right * vel * Time.deltaTime * Input.GetAxis ("Horizontal");
		Vector3 upMove = forward * vel * Time.deltaTime * Input.GetAxis ("Vertical");


		Vector3 heading = Vector3.Normalize (rightMove + upMove);

		transform.forward += heading;
		transform.position += rightMove;
		transform.position += upMove;

		RaycastHit hit;

		if (Input.GetButtonDown("Jump") && (Physics.Raycast(transform.position, Vector3.down, out hit, 1f))) {
			cubinho.AddForce(0, jump, 0, ForceMode.Impulse);
		}
			
	}


	void FixedUpdate ()
	{
		forward = Camera.main.transform.forward;
		forward.y = 0;
		forward = Vector3.Normalize (forward);
		right = Quaternion.Euler (new Vector3 (0, 90, 0)) * forward;	 
	}

	void Conversar () {
		
	}
		
}
