using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CellScript : MonoBehaviour {

	public float z;
	public GameObject CellPrefab;
	public GameObject GravePrefab;
	public GameObject EyePrefab;
<<<<<<< HEAD
=======
	public GameObject HangTreeLeftPrefab;
>>>>>>> Latest Version
	public float speed = 0.75f;
	public Vector3 cellSize;
	float despawnPoint;
	float offset;

	// Use this for initialization
	void Start () {
		z = transform.position.z;
<<<<<<< HEAD
		despawnPoint = -CellPrefab.renderer.bounds.size.z;
=======
		cellSize = CellPrefab.renderer.bounds.size;
		despawnPoint = -cellSize.z;
>>>>>>> Latest Version
	}

	// Update is called once per frame
	void Update () {
		//transform.Translate(new Vector3(0,0, -0.5f));

<<<<<<< HEAD
		z -= CellPrefab.renderer.bounds.size.z * Time.deltaTime * speed;
=======
		z -= cellSize.z * Time.deltaTime * GlobalVariables.speed;
>>>>>>> Latest Version
		transform.position = new Vector3 (0,0, z);

		if(z <= despawnPoint){
			//transform.position = new Vector3(0,0, 56);
			//script1.makeCell();
			offset = z - despawnPoint;
			//Destroy(gameObject);
			z = 4*CellPrefab.renderer.bounds.size.z + offset;
			Instantiate(GravePrefab, new Vector3(0, 0, z), Quaternion.identity);
<<<<<<< HEAD
			Instantiate(EyePrefab, new Vector3(6, 0, z), Quaternion.identity);
			Instantiate(GravePrefab, new Vector3(-6, 0, z), Quaternion.identity);
=======
			Instantiate(EyePrefab, new Vector3(
				(float)(transform.position.x + (0.25 * cellSize.x)), 0, z), Quaternion.identity);

			Instantiate(GravePrefab, new Vector3(
				(float)(transform.position.x - (0.25 * cellSize.x)), 0, z), Quaternion.identity);
>>>>>>> Latest Version
		}


	}
}
