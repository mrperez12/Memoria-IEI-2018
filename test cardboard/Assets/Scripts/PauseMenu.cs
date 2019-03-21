﻿using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

	public float fillTime = 2f;
	private float time;
	public Slider mySlider;
	private bool gazeAt;
	private Coroutine fillSlide;
	public int scene;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void PointerEnter(){

		mySlider.gameObject.SetActive (true);

		gazeAt = true;

		fillSlide = StartCoroutine (fill());

	}

	public void PointerExit(){

		gazeAt = false;

		if (fillSlide != null) {
			StopCoroutine(fillSlide);
		}
		time = 0f;
		mySlider.value = 0f;
		mySlider.gameObject.SetActive (false);
	}

	private IEnumerator fill(){

		time = 0f;

		while (time < fillTime) {

			time += Time.deltaTime;

			mySlider.value = time / fillTime;

			yield return  null;

			if (gazeAt) {

				continue;
			}

			time = 0f;
			mySlider.value = 0f;
			yield break;
		}
		Health.crucialActions = 0;
		Health.discoveredZones = 0;
		loadLevel (scene);
	}

	private void loadLevel(int level){

		SceneManager.LoadScene (level);
	}
}