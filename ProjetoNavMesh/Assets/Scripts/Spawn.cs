using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	//[SerializeField] private int quantidade;
	[SerializeField] private int valorX;
	[SerializeField] private int valorZ;
	[SerializeField] private GameObject enemy;
	/*[SerializeField] private int velocidade;
	[SerializeField] private int XMax;
	[SerializeField] private int XMin;
	[SerializeField] private int ZMax;
	[SerializeField] private int ZMin;
*/
	// Use this for initialization
	void Start () {
		RandomPosition ();
	}
	
	// Update is called once per frame
	void Update () {
		SpawnEnemy ();
	}

	private void RandomPosition () {

		//var position = Vector3(Random.Range(XMin, XMax), 0, Random.Range(ZMin, ZMax));
		valorX = Random.Range (-100, 100);
		valorZ = Random.Range (-100, 100);



		}

	private void SpawnEnemy () {

		Instantiate (Enemy, transform.position (valorX, 0, valorZ), Quaternion.identity);

		/*if (quantidade = 1) {
						Instantiate (gameObject.tag == "Enemy", transform.position (valorX, 0, valorZ), Quaternion.identity);
				} else if (quantidade = 2) {
			Instantiate (gameObject.tag == "Enemy", transform.position (valorX, 0, valorZ), Quaternion.identity);
			Instantiate (gameObject.tag == "Enemy", transform.position (valorX, 0, valorZ), Quaternion.identity);
				} else if (quantidade = 3) {
			Instantiate (gameObject.tag == "Enemy", transform.position (valorX, 0, valorZ), Quaternion.identity);
			Instantiate (gameObject.tag == "Enemy", transform.position (valorX, 0, valorZ), Quaternion.identity);
			Instantiate (gameObject.tag == "Enemy", transform.position (valorX, 0, valorZ), Quaternion.identity);
				} */     	
	}
}
