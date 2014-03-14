using UnityEngine;
using System.Collections;

public class GlobalVariables : MonoBehaviour {

	public static float speed = 0.75f;
	public float swag = 0.75f;
	public static float leftLane = -5;
	public static float midLane = 0;
	public static float rightLane = 5;
	public static float rightCosmetic = 11;
	public static float leftCosmetic = -11;
	public GUIText gTex2;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		speed = swag;
		speed = 0.4f + ((ScoreScript.time - ((ScoreScript.time%30))/100)*0.05f) * Time.deltaTime;
		gTex2.guiText.text = (speed).ToString ();
	}
}