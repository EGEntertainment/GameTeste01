using UnityEngine;
using System.Collections;

public class Identify : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void OnTriggerEnter (Collider Hero){

	   Debug.Log ("Abrir Caixa de Dialogo");					 

	}

	void OnTriggerExit (Collider Hero){

	   Debug.Log ("Fechar Caixa de Dialogo");					 
			
	}
}