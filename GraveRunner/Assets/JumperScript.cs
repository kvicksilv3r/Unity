using UnityEngine;
using System.Collections;

public class JumperScript : MonoBehaviour
{

    public static float height;
    //private bool canMove = true;
    public float jumpTime = 2;
    public float diveTime = 2;
    public float sinx = 0;
    public bool goingUp = false;
    public bool goingDown = false;
    public float startPos = 0;
    public float curPos = 0;

    // Use this for initialization
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0 && 
            Input.GetTouch(0).phase == TouchPhase.Began) {
            startPos = Input.GetTouch(0).deltaPosition.y;
        }

		if (Input.touchCount > 0 && 
		    Input.GetTouch(0).phase == TouchPhase.Ended) {
			startPos = 0;
			curPos = 0;
		}

		if (Input.touchCount > 0 && 
		    Input.GetTouch(0).phase == TouchPhase.Canceled) {
			startPos = 0;
			curPos = 0;
		}

        if (Input.touchCount > 0 && 
            Input.GetTouch(0).phase == TouchPhase.Moved) {
            
            // Get movement of the finger since last frame
            curPos = Input.GetTouch(0).deltaPosition.y;

        }
    
        if((curPos - startPos) < -100){
            if (!goingDown && !goingUp)
            {
                goingDown = true;        
                sinx = 0.55f;
                startPos = curPos;
            }
        }

        if((curPos - startPos) > 100){
            if (!goingDown && !goingUp)
            {
                goingUp = true;        
                sinx = 0.55f; 
                startPos = curPos;
            }
        }


        if (Input.GetKeyDown("w"))
        {

            //iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("jumPath"),
            //"time", jumpTime/(GlobalVariables.speed + 0.5f), "delay", 0));

            if (!goingUp && !goingDown)
            {
                goingUp = true;        
                sinx = 0.55f; 
            }

        }

        if (Input.GetKeyDown("s"))
        {

            //iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("divePath"),
            //"time", diveTime/(GlobalVariables.speed + 0.5f), "delay", 0));

            if (!goingDown && !goingUp)
            {
                goingDown = true;        
                sinx = 0.55f; 
            }

        }

        if (goingUp)
        {
            transform.Translate(0, Mathf.Sin(sinx * 1.55f) / 4, 0);
            
            if (transform.position.y <= GlobalVariables.playerDefHeight)
            {
                goingUp = false;
                goingDown = false;
                transform.position = new Vector3(0, GlobalVariables.playerDefHeight, 0);
            }
        }        
        if (goingDown)
        {
            transform.Translate(0, -Mathf.Sin(sinx * 1.5f) / 4, 0);
            
            if (transform.position.y >= GlobalVariables.playerDefHeight)
            {
                goingDown = false;
                goingUp = false;
                transform.position = new Vector3(0, GlobalVariables.playerDefHeight, 0);
            }
        }  

        height = transform.position.y;

        sinx += 0.1f;

    }
}

/*


// Moves object according to finger movement on the screen
    function Update () {
        if (Input.touchCount > 0 && 
          Input.GetTouch(0).phase == TouchPhase.Moved) {
        
            // Get movement of the finger since last frame
            var touchDeltaPosition:Vector2 = Input.GetTouch(0).deltaPosition;
            
            // Move object across XY plane
            transform.Translate (-touchDeltaPosition.x * speed, 
                        -touchDeltaPosition.y * speed, 0);
        }
    }


        */ 

