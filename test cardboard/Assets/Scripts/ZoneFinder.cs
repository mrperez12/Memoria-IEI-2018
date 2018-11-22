using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoneFinder : MonoBehaviour {
	
	public GameObject safeSymbol;
	public GameObject safeParticles;
	int max = 1;
	int i = 0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}
	void OnTriggerEnter (Collider other){
		if (other.tag == "Player") {
			safeSymbol.SetActive (true);
			safeParticles.SetActive (true);
			if(i<max){
				Health.discoveredZones += 1;
				Debug.Log (Health.discoveredZones);
				i += 1;
			}
		}
	}
}
