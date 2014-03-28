using UnityEngine;
using System.Collections;

public class GlobalVariables : MonoBehaviour {

	public static float speed = 0.75f;
	public float swag = 0.75f;
	public static float leftLane = -5;
	public static float midLane = 0;
	public static float rightLane = 5;
    public static float playerDefHeight = 2.4f;
	public static float rightCosmetic = 11;
	public static float leftCosmetic = -11;
    public static int lastCell = 0;
	public GUIText gTex2;


	// Use this for initialization
	void Start () {	
        ResetLevel();
	}

    public static void ResetLevel(){
        speed = 0.4f;
        PlayerScript.alive = true;
        PlayerScript.playerHp = 3;
        ScoreScript.score = 0;
        ScoreScript.time = 0;
    }
	
	// Update is called once per frame
	void Update () {
	
		speed = swag;
        if(PlayerScript.alive){
		speed = 0.4f + ((ScoreScript.time - ((ScoreScript.time%30))/90)*0.06f) * Time.deltaTime;
        }
        else{
            speed = 0;
        }
        gTex2.guiText.text = "speed = " + (speed).ToString ();
	}
}