using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrucialFinderActivator : MonoBehaviour {

	public GameObject action;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter (Collider other){
		if (other.tag == "Player") {
			action.GetComponent<CrucialActionsFinder> ().enabled = true;
			}
	}

	void OnTriggerExit(Collider other){
		if (other.tag == "Player") {
			action.GetComponent<CrucialActionsFinder> ().enabled = false;
		}
	}
}
