using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CellScript : MonoBehaviour {

	public float z;
	public GameObject CellPrefab;
	public GameObject GravePrefab;
	public GameObject EyePrefab;

	public GameObject HangTreeLeftPrefab;

	public float speed = 0.75f;
	public Vector3 cellSize;
	float despawnPoint;
	float offset;

	// Use this for initialization
	void Start () {
		z = transform.position.z;

		despawnPoint = -CellPrefab.renderer.bounds.size.z;

		cellSize = CellPrefab.renderer.bounds.size;
		despawnPoint = -cellSize.z;

	}

	// Update is called once per frame
	void Update () {


		z -= cellSize.z * Time.deltaTime * GlobalVariables.speed;

		transform.position = new Vector3 (0,0, z);

		if(z <= despawnPoint){

			offset = z - despawnPoint;

			z = 4*CellPrefab.renderer.bounds.size.z + offset;

			Instantiate(GravePrefab, new Vector3(0, 0, z), Quaternion.identity);

			//Instantiate(EyePrefab, new Vector3(6, 0, z), Quaternion.identity);
			//Instantiate(GravePrefab, new Vector3(-6, 0, z), Quaternion.identity);

			Instantiate(EyePrefab, new Vector3(
				(float)(transform.position.x + (0.25 * cellSize.x)), 0, z), Quaternion.identity);

			Instantiate(GravePrefab, new Vector3(
				(float)(transform.position.x - (0.25 * cellSize.x)), 0, z), Quaternion.identity);

		}


	}
}
