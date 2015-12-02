using UnityEngine;
using System.Collections;

public class Bala : MonoBehaviour {
	public float velocidadeBala;

	// Use this for initialization
	void Start () {
		GameObject playerArma;
		playerArma = GameObject.Find("Arma");
		GetComponent<Rigidbody>().AddForce(playerArma.transform.forward * velocidadeBala);	
	}
	
	// Update is called once per frame
	void Update () {
		//Destroy a Bala depois de 2F
		Destroy(gameObject, 2f);	
	}
	//Destroi o carro ao bater no carro
	void OnCollisionEnter (Collision outroCarro){	
		if(outroCarro.gameObject.tag == "Enemy"){
			Destroy(outroCarro.gameObject);
			Debug.Log("Collidiu");
		}
	}
}
