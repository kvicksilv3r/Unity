using UnityEngine;
using System.Collections;

public class JumperScript : MonoBehaviour {

	public static float height;
	//private bool canMove = true;
	public float jumpTime = 2;
	public float diveTime = 2;
    public float sinx = 0;
    public bool goingUp = false;
    public bool goingDown = false;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {


		if (Input.GetKeyDown("w")) {

			//iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("jumPath"),
            //"time", jumpTime/(GlobalVariables.speed + 0.5f), "delay", 0));

            if(!goingUp && !goingDown)
            {
                goingUp = true;        
                sinx = 0.55f; 
            }

				}

		if (Input.GetKeyDown("s")) {

			//iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("divePath"),
            //"time", diveTime/(GlobalVariables.speed + 0.5f), "delay", 0));

            if(!goingDown && !goingUp)
            {
                goingDown = true;        
                sinx = 0.55f; 
            }

		}

        if(goingUp) 
        {
            transform.Translate(0, Mathf.Sin(sinx*1.55f)/4,0);
            
            if(transform.position.y <= GlobalVariables.playerDefHeight)
            {
                goingUp = false;
                goingDown = false;
                transform.position = new Vector3(0, GlobalVariables.playerDefHeight, 0);
            }
        }        
        if(goingDown)
        {
            transform.Translate(0, -Mathf.Sin(sinx*1.5f)/4,0);
            
            if(transform.position.y >= GlobalVariables.playerDefHeight)
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


 IN UPDATE---

sinx += 0.1;

---

if(nextLane > 3)
        {
            nextLane = 3;
        }
        else if(nextLane < 1)
        {
            nextLane = 1;
        }
        
        //-----------------------------------------
                
        if(goingUp) 
        {
            player.model.move(0, FastMath.sin(sinx*1.75f)/7,0);
            
            if(player.position.y <= defaultPos.y)
            {
                goingUp = false;
            }
        }        
        if(goingDown)
        {
            player.model.move(0, -FastMath.sin(sinx*1.9f)/5,0);
            
            if(player.position.y >= defaultPos.y)
            {
                goingDown = false;
            }
        }  
        //-----------------------------------------
            
            if(goingLeft)
            {
                //if(currLane > nextLane)
                //{
                    if(nextLane == 1)
                    {
                        if((player.position.x - (0.52*extent.x)*4*tpf) < leftLane.x )
                        {
                            goingLeft = false;
                            currLane = 1;
                            player.position.x = leftLane.x;
                        }
                        else if(player.position.x > leftLane.x)
                        {
                        player.position.x -= (0.52*extent.x)*4*tpf;
                        }                        

                    }
                //}
                    
                    if(nextLane == 2)
                    {
                        if((player.position.x - (0.52*extent.x)*4*tpf) < defaultPos.x )
                        {
                            goingLeft = false;
                            currLane = 2;
                            player.position.x = defaultPos.x;
                        }
                        else if(player.position.x > defaultPos.x)
                        {
                        player.position.x -= (0.52*extent.x)*4*tpf;
                        }

                    }
            }
            
            if(goingRight)
            {
                //if(currLane > nextLane)
                //{
                    if(nextLane == 3)
                    {
                        if((player.position.x + (0.52*extent.x)*4*tpf) > rightLane.x)
                        {
                            goingRight = false;
                            currLane = 3;
                            player.position.x = rightLane.x;
                        }
                        else if(player.position.x < rightLane.x)
                        {
                        player.position.x += (0.52*extent.x)*4*tpf;
                        }
                    }
                     
                    if(nextLane == 2)
                    {
                        if((player.position.x + (0.52*extent.x)*4*tpf) > defaultPos.x)
                        {
                            goingRight = false;
                            currLane = 2;
                            player.position.x = defaultPos.x;
                        }
                        else if(player.position.x < defaultPos.x)
                        {
                        player.position.x += (0.52*extent.x)*4*tpf;
                        }
                    }


        */ 

