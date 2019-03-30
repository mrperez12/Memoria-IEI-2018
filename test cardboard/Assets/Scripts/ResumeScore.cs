using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResumeScore : MonoBehaviour {

	// Imagenes correspondientes a las zonas seguras descubiertas.
	public Image symbol1;
	public Image symbol2;
	public Image symbol3;
	public Image symbol4;
	public Image symbol5;
	public Image symbol6;
	public Image symbol7;
	public Image symbol8;
	public Image symbol9;
	public Button button;
	public Button info;
	public Image key1;
	public Image key2;
	public Image key3;
	public Camera vrCamera;

	// Use this for initialization
	void Start () {

		vrCamera.transform.rotation = Quaternion.Euler (0.0f, 0.0f, 0.0f);
		StartCoroutine(Example());

	}

	// Update is called once per frame
	void Update () {
		
	}

	//Funcion que verifica la cantidad de zonas seguras visitadas. Segun la cantidad
	//estas se revelan como encontradas, cambiando su color de negro a blanco.
	void DiscoveredZoneCheck(){
		if (Health.discoveredZones == 1) {

			symbol1.color = Color.white;
		}
		if (Health.discoveredZones == 2) {

			symbol1.color = Color.white;
			symbol2.color = Color.white;
		}
		if (Health.discoveredZones == 3) {

			symbol1.color = Color.white;
			symbol2.color = Color.white;
			symbol3.color = Color.white;
		}
		if (Health.discoveredZones == 4) {

			symbol1.color = Color.white;
			symbol2.color = Color.white;
			symbol3.color = Color.white;
			symbol4.color = Color.white;
		}
		if (Health.discoveredZones == 5) {

			symbol1.color = Color.white;
			symbol2.color = Color.white;
			symbol3.color = Color.white;
			symbol4.color = Color.white;
			symbol5.color = Color.white;
		}
		if (Health.discoveredZones == 6) {

			symbol1.color = Color.white;
			symbol2.color = Color.white;
			symbol3.color = Color.white;
			symbol4.color = Color.white;
			symbol5.color = Color.white;
			symbol6.color = Color.white;
		}
		if (Health.discoveredZones == 7) {

			symbol1.color = Color.white;
			symbol2.color = Color.white;
			symbol3.color = Color.white;
			symbol4.color = Color.white;
			symbol5.color = Color.white;
			symbol6.color = Color.white;
			symbol7.color = Color.white;
		}
		if (Health.discoveredZones == 8) {

			symbol1.color = Color.white;
			symbol2.color = Color.white;
			symbol3.color = Color.white;
			symbol4.color = Color.white;
			symbol5.color = Color.white;
			symbol6.color = Color.white;
			symbol7.color = Color.white;
			symbol8.color = Color.white;
		}
		if (Health.discoveredZones == 9) {

			symbol1.color = Color.white;
			symbol2.color = Color.white;
			symbol3.color = Color.white;
			symbol4.color = Color.white;
			symbol5.color = Color.white;
			symbol6.color = Color.white;
			symbol7.color = Color.white;
			symbol8.color = Color.white;
			symbol9.color = Color.white;
		}
		if (Health.crucialActions == 1) {

			key1.color = Color.white;
		}
		if (Health.crucialActions == 2) {

			key1.color = Color.white;
			key2.color = Color.white;
		}
		if (Health.crucialActions == 3) {

			key1.color = Color.white;
			key2.color = Color.white;
			key3.color = Color.white;
		}
		//Reiniciamos el contador para una nueva experiencia.
		Health.discoveredZones = 0;
		Health.crucialActions = 0;
		button.gameObject.SetActive (true);
		info.gameObject.SetActive (true);

	}

	//Luego de cinco segundos se revelan la cantidad de zonas encontradas.
	IEnumerator Example(){
		yield return new WaitForSeconds (5.0f);
		DiscoveredZoneCheck ();
	}

}
