using UnityEngine;
using System.Collections;

public class Atirador : MonoBehaviour {
	public Transform bala;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Instancia projetil
		if(Input.GetMouseButtonDown(0)){
			Instantiate(bala, transform.position, Quaternion.identity);

		}
	
	}
}
