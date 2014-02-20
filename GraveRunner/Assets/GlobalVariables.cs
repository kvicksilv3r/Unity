using UnityEngine;
using System.Collections;

public class GlobalVariables : MonoBehaviour {

	public static float speed = 0.75f;
	public float swag = 0.75f;
	public static float leftLane = -5;
	public static float midLane = 0;
	public static float rightLane = 5;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		speed = swag;
	}
}
