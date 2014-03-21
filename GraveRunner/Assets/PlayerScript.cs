﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerScript : MonoBehaviour
{

    public int currLane = 1;
    public float[] lane;
    public bool isInLane = true;
    public float currHeight;
    public float defaultHeight;
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
        GlobalVariables.playerDefHeight = defaultHeight;
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

