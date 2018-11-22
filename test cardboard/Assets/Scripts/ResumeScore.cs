using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResumeScore : MonoBehaviour {

	public Image symbol1;
	public Image symbol2;
	public Image symbol3;
	public Image symbol4;
	public Image symbol5;
	public Image symbol6;
	public Image symbol7;
	public Camera vrCamera;

	// Use this for initialization
	void Start () {

		vrCamera.transform.rotation = Quaternion.Euler (0.0f, 0.0f, 0.0f);
		StartCoroutine(Example());

	}

	// Update is called once per frame
	void Update () {
		
	}

	void DiscoveredZoneCheck(){
		if (Health.discoveredZones == 1) {

			symbol1.color = Color.white;
		}
		if (Health.discoveredZones == 2) {

			symbol1.color = Color.white;
			symbol2.color = Color.white;
		}
		if (Health.discoveredZones == 3) {

			symbol1.color = Color.white;
			symbol2.color = Color.white;
			symbol3.color = Color.white;
		}
		if (Health.discoveredZones == 4) {

			symbol1.color = Color.white;
			symbol2.color = Color.white;
			symbol3.color = Color.white;
			symbol4.color = Color.white;
		}
		if (Health.discoveredZones == 5) {

			symbol1.color = Color.white;
			symbol2.color = Color.white;
			symbol3.color = Color.white;
			symbol4.color = Color.white;
			symbol5.color = Color.white;
		}
		if (Health.discoveredZones == 6) {

			symbol1.color = Color.white;
			symbol2.color = Color.white;
			symbol3.color = Color.white;
			symbol4.color = Color.white;
			symbol5.color = Color.white;
			symbol6.color = Color.white;
		}
		if (Health.discoveredZones == 7) {

			symbol1.color = Color.white;
			symbol2.color = Color.white;
			symbol3.color = Color.white;
			symbol4.color = Color.white;
			symbol5.color = Color.white;
			symbol6.color = Color.white;
			symbol7.color = Color.white;
		}
		Health.discoveredZones = 0;

	}

	IEnumerator Example(){
		yield return new WaitForSeconds (5.0f);
		DiscoveredZoneCheck ();
	}

}
