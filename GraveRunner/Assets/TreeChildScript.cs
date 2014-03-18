using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TreeChildScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.rotation = Quaternion.Euler(0, Random.value * 360, 0);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
