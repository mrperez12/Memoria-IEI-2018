using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {

	public static Control control;
	/*Por el momento deben listarse todas las zonas seguras a activar y desactivar.
	Pueden haber mas de las que se utilicen en una etapa.*/
	public int securedZones = 0;

	// Use this for initialization
	void Awake(){
		if (control == null) {
			DontDestroyOnLoad (gameObject);
			control = this;
		}
		else if(control != this){
			Destroy (gameObject);	
		}
	}
}
