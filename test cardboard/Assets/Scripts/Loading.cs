using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Loading : MonoBehaviour {
	AsyncOperation async;
	public Slider charger;
	float targetCharge;
	float timer = 5;
	// Use this for initialization
	void Start () {
		charger.value = 0;
		async =  SceneManager.LoadSceneAsync("House");
		async.allowSceneActivation = false;
		// ...and start a coroutine that will load the desired scene.
		//StartCoroutine(LoadNewScene());

	}
	
	// Update is called once per frame
	void Update () {
		charger.value = charger.value * 0.9f + (targetCharge+0.09f) * 0.1f;
		targetCharge = async.progress;
		/*if (!async.isDone) {
			//do something;
		}*/
		timer -= Time.deltaTime;
		if (timer < 0) {
			charger.value = 1;
			async.allowSceneActivation = true;
		}
	}

	// The coroutine runs on its own at the same time as Update() and takes an string indicating which scene to load.
	IEnumerator LoadNewScene() {

		// Start an asynchronous operation to load the scene that was passed to the LoadNewScene coroutine.
		AsyncOperation async =  SceneManager.LoadSceneAsync("House");

		// While the asynchronous operation to load the new scene is not yet complete, continue waiting until it's done.
		while (!async.isDone) {
			yield return null;
		}

	}
}
