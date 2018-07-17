using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteract : MonoBehaviour {

	public Canvas canvas;
	public int dialogLevel;


	void Start () {

		canvas.enabled = false;
		dialogLevel = 1;

	}

	void OnTriggerStay (Collider other){

		if (Input.GetButtonDown("Fire1")) {

			if (dialogLevel == 1) {
				canvas.enabled = true;
				Debug.Log ("funcionou desgraça");
				dialogLevel++;
			}
			if (dialogLevel == 2) {
				canvas.enabled = true;
				Debug.Log ("funcionou denovo");
				dialogLevel++;
			}
			if (dialogLevel == 3) {
				canvas.enabled = true;
				Debug.Log ("puta merda funcionou pra caralho");
				dialogLevel++;
			}
			if (dialogLevel >= 4) {
				canvas.enabled = true;
				Debug.Log ("agora descobrir como desgraças jogar isso no texto");
				dialogLevel++;
			}

		}

	}

	void OnTriggerExit (Collider other){
	
		canvas.enabled = false;

	}

	void Update () {


	}
}
