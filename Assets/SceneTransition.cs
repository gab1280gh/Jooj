using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame	
	void Update () {

	}

	void OnTriggerEnter (Collider other){
		
		if (other.gameObject.name == "Player") {
			Debug.Log("collision worked");
			SceneManager.LoadScene ("interior", LoadSceneMode.Single);
		}

	}

	IEnumerator LoadYourAsyncScene()
	{
		// The Application loads the Scene in the background at the same time as the current Scene.
		//This is particularly good for creating loading screens. You could also load the Scene by build //number.
		AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("interior");

		//Wait until the last operation fully loads to return anything
		while (!asyncLoad.isDone)
		{
			yield return null;
		}
	}
}