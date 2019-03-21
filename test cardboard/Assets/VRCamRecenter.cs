using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class VRCamRecenter : MonoBehaviour {

	public Camera cam;

	// Use this for initialization
	// Script utilizado para centrar la camara con los paneles al pasar de una escena a otra.
	void Start () {
		InputTracking.disablePositionalTracking = true;
		InputTracking.Recenter ();
		InputTracking.disablePositionalTracking = false;
		GvrCardboardHelpers.Recenter ();
		Debug.Log ("VR Recenter");
		//cam.GetComponent<GvrEditorEmulator>().Recenter ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
