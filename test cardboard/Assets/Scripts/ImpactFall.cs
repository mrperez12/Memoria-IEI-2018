using UnityEngine;
using System.Collections;

public class ImpactFall : MonoBehaviour {
	public AudioClip sound;

	void OnCollisionEnter (Collision other)
	{
		if (other.relativeVelocity.magnitude >= 1) 
		{
			GetComponent<AudioSource>().clip = sound;
			GetComponent<AudioSource> ().volume = Mathf.Pow(other.relativeVelocity.magnitude,2)/45;
			//Debug.Log(GetComponent<AudioSource> ().volume);
			GetComponent<AudioSource>().Play ();
		}
	}
}
