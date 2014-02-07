using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CellScript : MonoBehaviour {

	public float z;
	public GameObject CellPrefab;
	public float speed = 0.75f;
	float despawnPoint;
	float offset;

	// Use this for initialization
	void Start () {
		z = transform.position.z;
		despawnPoint = -CellPrefab.transform.lossyScale.z * 8;
	}

	// Update is called once per frame
	void Update () {
		//transform.Translate(new Vector3(0,0, -0.5f));

		z -= CellPrefab.transform.lossyScale.z * 8 * Time.deltaTime * speed;
		transform.position = new Vector3 (0,0, z);

		if(z <= despawnPoint){
			//transform.position = new Vector3(0,0, 56);
			//script1.makeCell();
			offset = z - despawnPoint;
			//Destroy(gameObject);
			z = 4*CellPrefab.transform.lossyScale.z*8 + offset;
		}


	}
}
