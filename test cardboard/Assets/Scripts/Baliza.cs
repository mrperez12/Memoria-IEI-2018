using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baliza : MonoBehaviour {

	public GameObject player;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if (other.tag == "Wall") {
			player.GetComponent<vrViewMovement> ().enabled = false;
			}
	}

	void OnTriggerExit(Collider other){
		if (other.tag == "Wall") {
			player.GetComponent<vrViewMovement> ().enabled = true;
		}
	}
}
