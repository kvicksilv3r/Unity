using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerScript : MonoBehaviour {

	public int currLane = 1;
	public float[] lane;
	public bool isInLane = true;
	public float currHeight;
	public float defaultHeight;
	bool goingUp = false;
	bool goingDown = false;
	public GameObject Jumper;

	//test 
	public static Vector3[]jumpPath = new Vector3[3];

	// Use this for initialization
	void Start () {
		lane = new float[]{-4.5f, 0, 4.5f};
		jumpPath = iTweenPath.GetPath("dapath");
		currHeight = transform.position.y;
		defaultHeight = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {

		/*
		currHeight = JumperScript.height;

		//if (!isInLane){
			iTween.MoveTo(gameObject, new Vector3(lane[currLane], currHeight, 0), (0.5f/GlobalVariables.speed));
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
						*/

		transform.position = new Vector3 (VerticalMovementScript.verticalPos, JumperScript.height, 0);

				
		
	}
}
