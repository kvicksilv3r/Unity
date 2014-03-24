using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {
	public static int score;
	public static float time;
	public static float displayTime;
	public GUIText gTex;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(PlayerScript.alive){
		time += Time.deltaTime;
        }
		displayTime = time/2;

		gTex.guiText.text = "Score: " + Mathf.RoundToInt (10 * displayTime).ToString ();
        score = Mathf.RoundToInt (10 * displayTime);
		}
}