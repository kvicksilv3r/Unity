using UnityEngine;
using System.Collections;

public class MoonScript : MonoBehaviour {

    public static int moveTime = 0;
    public float moveSpeed = 0.05f;
    public static int defMoveTime = 150;

	// Use this for initialization
	void Start () {
        moveTime = 0;
	}

    public static void setTime()
    {
        moveTime = defMoveTime;
    }
	
	// Update is called once per frame
	void Update () {
	    if(moveTime > 0){
            transform.Translate(new Vector3(0, 0, -moveSpeed));
            moveTime--;
        }
	}
}
