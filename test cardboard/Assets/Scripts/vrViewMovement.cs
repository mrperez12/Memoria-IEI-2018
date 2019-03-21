using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vrViewMovement : MonoBehaviour {

	public Transform vrCamera;
	public GameObject menu;
	public float toggleAngle = 30.0f;
	public float upperToggleAngle = 90.0f;
	public float speed = 3.0f;
	public bool move;
	public float stairsToggleAngle = 30.0f;
	public float stairsUpperToggleAngle = 90.0f;

	private CharacterController cc;

	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterController> ();	
	}
	
	// Update is called once per frame
	void Update () {
		if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < upperToggleAngle) {
			move = true;
		} else {
			Vector3 menuposition = menu.transform.eulerAngles;
			menuposition.y = vrCamera.transform.eulerAngles.y;
			menu.transform.eulerAngles = menuposition;
			move = false;
		}
		if (move) {
			Vector3 forward = vrCamera.TransformDirection (Vector3.forward);
			cc.SimpleMove (forward * speed);
		}

	}
}
