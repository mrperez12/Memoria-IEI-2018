using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrucialActionsFinder : MonoBehaviour {
	public GameObject actionSymbol;
	public GameObject secureSymbol;

	int max = 1;
	int i = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void PointerEnter(){
		if (this.GetComponent<CrucialActionsFinder> ().enabled == true) {
			actionSymbol.SetActive (false);
			secureSymbol.SetActive (true);
			if (i < max) {
				Health.crucialActions += 1;
				Debug.Log ("Funciona el crucial");
				Debug.Log (Health.crucialActions);
				i += 1;
			}
		} else {
			Debug.Log ("Desactivado");
		}

	}
}
