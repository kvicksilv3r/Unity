using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {
	public int score;
	public static float time;
	public static float displayTime;
	public GUIText gTex;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		displayTime = time/2;

		gTex.guiText.text = Mathf.RoundToInt (displayTime).ToString ();
		}
}