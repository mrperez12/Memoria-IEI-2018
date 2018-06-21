using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Health : MonoBehaviour {
	public int startingHealth = 100;
	public int currentHealth;
	public Slider health;
	public bool safe;
	public bool danger;

	// Use this for initialization
	void Start () {
		//Cursor.lockState = CursorLockMode.Locked;
		currentHealth = startingHealth;
		health.value = currentHealth;
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter (Collider other){
		if (other.tag == "safezone") {
			//Debug.Log ("Safe ZONE MADAFAKA");
			safe = true;
			InvokeRepeating ("HealDamage", 0.1f, 1.0f);
		}
		if (other.tag == "dangerzone") {
			//Debug.Log ("DANGEROUS ZONE MADAFAKA");
			danger = true;
			InvokeRepeating ("EarthquakeDamage", 0.1f, 1.0f);
		}
	}
	void OnTriggerExit (Collider other)
	{
		if (other.tag == "safezone") {
			Debug.Log ("Exit Safe Zone");
			safe = false;
			CancelInvoke ();
		}
		if (other.tag == "dangerzone") {
			//Debug.Log ("DANGEROUS ZONE MADAFAKA");
			danger = false;
			CancelInvoke ();
		}
	}
	void EarthquakeDamage()
	{
		currentHealth -= 2;
		health.value = currentHealth;
	}
	void HealDamage()
	{
		currentHealth += 1;
		health.value = currentHealth;
	}
}
