using UnityEngine;
using System.Collections;

public class DethScreenScript : MonoBehaviour {

    public float x;
    public TextMesh ScoreText;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    if(!PlayerScript.alive && transform.position.x < 0) {
            x += 0.3f;
        }
        else if(!PlayerScript.alive && transform.position.x > 0){
            x = 0;
        }

        if(PlayerScript.alive){
            x = -7;
        }

        ScoreText.text = "... But you obtained a whooping " + ScoreScript.score.ToString() + " points!";
        transform.position = new Vector3(x, 6.2f,-7.379659f);
	}
}
