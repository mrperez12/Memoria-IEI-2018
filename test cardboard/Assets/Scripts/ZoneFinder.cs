using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoneFinder : MonoBehaviour {
	
	public GameObject safeSymbol;
	public GameObject safeParticles;
	public Image symbol;


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
			symbol.color = Color.white;
		}
	}
}
