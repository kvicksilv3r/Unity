using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class VerticalMovementScript : MonoBehaviour {

	public int currLane = 1;
	public float[] lane;
	public float verticalSpeed = 0.7f;

	public static float verticalPos;

	
	//test 
	public static Vector3[]jumpPath = new Vector3[3];
	
	// Use this for initialization
	void Start () {
		lane = new float[]{-4.5f, 0, 4.5f};

	}
	
	// Update is called once per frame
	void Update () {

		verticalPos = transform.position.x;

		//if (!isInLane){
		if (GlobalVariables.speed > 1) {
			iTween.MoveTo (gameObject, new Vector3 (lane [currLane], 0, 0), (verticalSpeed / GlobalVariables.speed / GlobalVariables.speed));
				} 

			else {
					iTween.MoveTo (gameObject, new Vector3 (lane [currLane], 0, 0), verticalSpeed);
				}
		//}
		
		if (Input.GetKeyDown("a")) {
			if(currLane > 0){
				currLane--;
			}
		}
		
		if (Input.GetKeyDown("d")) {
			if (currLane < 2) {
				currLane++;
			}
		}
		
		if (currLane < -1) {
			currLane = -1;
		}
		
		if (currLane > 2) {
			currLane = 2;
		}
		
	}
}