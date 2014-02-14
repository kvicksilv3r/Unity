using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CellScript : MonoBehaviour {

	public float z;
	public GameObject CellPrefab;
	public GameObject GravePrefab;
	public GameObject EyePrefab;
	public float speed = 0.75f;
	float despawnPoint;
	float offset;

	// Use this for initialization
	void Start () {
		z = transform.position.z;
		despawnPoint = -CellPrefab.renderer.bounds.size.z;
	}

	// Update is called once per frame
	void Update () {
		//transform.Translate(new Vector3(0,0, -0.5f));

		z -= CellPrefab.renderer.bounds.size.z * Time.deltaTime * speed;
		transform.position = new Vector3 (0,0, z);

		if(z <= despawnPoint){
			//transform.position = new Vector3(0,0, 56);
			//script1.makeCell();
			offset = z - despawnPoint;
			//Destroy(gameObject);
			z = 4*CellPrefab.renderer.bounds.size.z + offset;
			Instantiate(GravePrefab, new Vector3(0, 0, z), Quaternion.identity);
			Instantiate(EyePrefab, new Vector3(6, 0, z), Quaternion.identity);
			Instantiate(GravePrefab, new Vector3(-6, 0, z), Quaternion.identity);
		}


	}
}
