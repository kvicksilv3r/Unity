using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HangTreeScript : MonoBehaviour {
	
	public float z;
	public float x;
	public GameObject CellPrefab;
	public float speed = 0.75f;
	float despawnPoint;
	
	// Use this for initialization
	void Start () {
		z = transform.position.z;
		x = transform.position.x;
		despawnPoint = -CellPrefab.renderer.bounds.size.z;	
	}
	
	// Update is called once per frame
	void Update () {
		z -= CellPrefab.renderer.bounds.size.z * Time.deltaTime * GlobalVariables.speed;
		transform.position = new Vector3 (x, 0, z);
		
		if(z <= despawnPoint){
			Destroy(gameObject);
		}
	}
}
