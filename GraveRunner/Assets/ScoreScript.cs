using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {
	public int score;
	public static float time;
	public GUIText gTex;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;

		gTex.guiText.text = Mathf.RoundToInt (time).ToString ();
		}
}