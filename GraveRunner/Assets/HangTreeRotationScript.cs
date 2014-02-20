using UnityEngine;
using System.Collections;

public class HangTreeRotationScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

		if (transform.parent.transform.position.x == 0) {
			if(Random.value >= 0.5f){
				transform.rotation = Quaternion.Euler(0, 180, 0);
			}
		}

		if (transform.parent.transform.position.x == GlobalVariables.leftLane) {
			 	transform.rotation = Quaternion.Euler(0, 180, 0);
				}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
