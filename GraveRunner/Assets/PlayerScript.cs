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

		transform.position = new Vector3 (VerticalMovementScript.verticalPos, JumperScript.height, 0);

	}

	void OnCollisionEnter (Collision col)
	{
		print ("Lel feg u ist das homo");
	}
}
