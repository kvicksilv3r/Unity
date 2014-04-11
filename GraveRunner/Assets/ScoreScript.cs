using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {
	public static float score;
	public static float time;
	public static float displayTime;
    public static float multiplierTime;
    public static float multiplier;
    public GUIText gTex;
    public GUIText gTex3;
    public GUIText gTex4;

	// Use this for initialization
	void Start () {
        gTex3 = GameObject.Find("hpGuiText").GetComponent<GUIText>() as GUIText;
        gTex4 = GameObject.Find("multiplierGUItext").GetComponent<GUIText>() as GUIText;
	}
	
	// Update is called once per frame
	void Update () {
        if(PlayerScript.alive){
            time += Time.deltaTime;
        }
        if(PlayerScript.alive){
            multiplierTime += Time.deltaTime;
        }
        multiplier = 1 + ((multiplierTime - ((multiplierTime % 2)) / 5) * 15) * Time.deltaTime;

		displayTime = time/2;

        if (PlayerScript.alive) {
            score += 10 * Time.deltaTime * multiplier;
        }
        gTex.guiText.text = "Score: " + Mathf.RoundToInt(score);

        gTex3.guiText.text = "Lives left: " + PlayerScript.playerHp.ToString ();
        gTex4.guiText.text = "Multiplier: " + multiplier.ToString ();
		}
}