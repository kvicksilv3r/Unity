using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class VerticalMovementScript : MonoBehaviour
{

    public int currLane = 1;
    public float[] lane;
    public float verticalSpeed = 0.7f;
    public static float startPos = 0;
    public static float curPos = 0;
    public static float verticalPos;
    public GUIText gTexYo;
    public bool canMove = false;
    public int moveDelay;

    
    //test 
    public static Vector3[]jumpPath = new Vector3[3];
    
    // Use this for initialization
    void Start()
    {
        lane = new float[]{GlobalVariables.leftLane, 0, GlobalVariables.rightLane};
    }
    
    // Update is called once per frame
    void Update()
    {
        #region TouchControlls
        if (Input.touchCount > 0 && 
            Input.GetTouch(0).phase == TouchPhase.Began)
        {
            curPos = Input.GetTouch(0).position.x;
            startPos = Input.GetTouch(0).position.x;
            canMove = true;
        }
        
        if (Input.touchCount > 0 && 
            Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            startPos = 0;
            curPos = 0;
        }
                
        if (Input.touchCount > 0 && 
            Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            
            // Get movement of the finger since last frame
            curPos = Input.GetTouch(0).position.x;
            
        }

        #endregion

        if ((curPos - startPos) < -100)
        {
            if (canMove)
            {
                if (currLane > 0)
                {
                    currLane--;
                }
                startPos = curPos;
                canMove = false;
                moveDelay = 10;
            }
        }
        
        if ((curPos - startPos) > 100)
        {
            if (canMove)
            {
                if (currLane < 2)
                {
                    currLane++;
                }
                startPos = curPos;
                canMove = false;
                moveDelay = 10;
            }
        }

        if (!canMove)
        {
            moveDelay--;
        }

        if (moveDelay <= 0)
        {
            canMove = true;
        }


        verticalPos = transform.position.x;

        //if (!isInLane){
        if (GlobalVariables.speed > 1)
        {
            iTween.MoveTo(gameObject, new Vector3(lane [currLane], 0, 0), (verticalSpeed / GlobalVariables.speed / GlobalVariables.speed));
        } else
        {
            iTween.MoveTo(gameObject, new Vector3(lane [currLane], 0, 0), verticalSpeed);
        }
        //}
        
        if (Input.GetKeyDown("a"))
        {
            if (currLane > 0)
            {
                currLane--;
            }
        }
        
        if (Input.GetKeyDown("d"))
        {
            if (currLane < 2)
            {
                currLane++;
            }
        }
        
        if (currLane < -1)
        {
            currLane = -1;
        }
        
        if (currLane > 2)
        {
            currLane = 2;
        }
        //----
        gTexYo.guiText.text = ("startX = " + startPos + " curX = " + curPos);
        //----
        
    }
}