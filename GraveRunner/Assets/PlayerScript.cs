using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerScript : MonoBehaviour
{

    public int currLane = 1;
    public float[] lane;
    public bool isInLane = true;
    public float currHeight;
    public float defaultHeight;
    bool goingUp = false;
    bool goingDown = false;
    public GameObject Jumper;
    public bool alive = true;
    public int playerHP = 3;
    public bool invul = false;
    public int invultime;

    //test 
    public static Vector3[]jumpPath = new Vector3[3];

    // Use this for initialization
    void Start()
    {
        lane = new float[]{-4.5f, 0, 4.5f};
        jumpPath = iTweenPath.GetPath("dapath");
        currHeight = transform.position.y;
        defaultHeight = transform.position.y;
    }
    
    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(VerticalMovementScript.verticalPos, JumperScript.height, 0);

        if (playerHP <= 0)
        {
            print("u ded sun");
            alive = false;
            playerHP = 1;
        }

        if (!alive)
        {
            //print ("U be the deddedest");
        }

        if (invul)
        {
            invultime --;
        }
        if (invultime < 1)
        {
            invul = false;
        }

    }

    void CollisionInvul()
    {
        invul = true;
        invultime = 30;
    }

    void OnCollisionEnter(Collision col)
    {
        if (!invul)
        {
            playerHP -= 1;
            print("Lel feg u ist das homo" + playerHP);
            CollisionInvul();
        }
    }

}

/*
        if (name.equals("UP")) {
        if(!goingUp && !goingDown)
        {
        goingUp = true;        
        sinx = 0.55f; 
        }          

        }
        
        if (name.equals("LEFT")) {
                 
        goingLeft = true; 
        goingRight = false;
                
        
        nextLane -= 1;
        
        }
        
        if (name.equals("RIGHT")) {    
       
       goingRight = true;
       goingLeft = false;      
                  
          nextLane += 1;     
        
        }
        
        if (name.equals("DOWN")) {          
        if(!goingDown && !goingUp)
        {
        goingDown = true;        
        sinx = 0.55f; 
        }
        }

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
