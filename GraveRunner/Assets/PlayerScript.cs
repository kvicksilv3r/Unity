using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerScript : MonoBehaviour {

	public int currLane = 1;

	public float[] lane;

	public bool isInLane = true;

	public float currHeight;

	// Use this for initialization
	void Start () {
		lane = new float[]{-4.5f, 0, 4.5f};
		//lane[0] = new float (-4.5f);
		//lane[1] = new float (0);
		//lane[2] = new float (4.5f);

		currHeight = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {

		currHeight = transform.position.y;

		if (!isInLane){
			iTween.MoveTo(gameObject, new Vector3(lane[currLane], currHeight, 0), (0.5f/GlobalVariables.speed));
		}

		if(transform.position.x != lane[currLane]){
			isInLane = false;
		} 
		else{
			isInLane = true;
		}

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
