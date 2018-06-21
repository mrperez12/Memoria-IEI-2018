using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour {

	public GameObject door;
	public float grade;
	public bool open = false;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter (Collider other){
		if (other.tag == "Player") {
			Debug.Log ("Entre");
			if (open == false) {
				if (grade > 0.0f) {
					for(float i=0.0f; i<= grade; i++)
					{
						door.transform.Rotate (0, 1, 0);
					}
					open = true;
				}
				else if(grade < 0.0f){
					for(float i=0.0f; i>= grade; i--)
					{
						door.transform.Rotate (0, -1, 0);
					}
					open = true;
				}
			}

		}
	}
}
