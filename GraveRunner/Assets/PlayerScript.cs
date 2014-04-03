using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerScript : MonoBehaviour
{
    public static int playerHp = 3;
    public int currLane = 1;
    public float currHeight;
    public float defaultHeight;
    public GameObject Jumper;
    public static bool alive = true;
    public bool invul = false;
    public int invultime;
    Animator anim;

    //test 
    public static Vector3[]jumpPath = new Vector3[3];

    // Use this for initialization
    void Start()
    {
        transform.position = new Vector3(0, GlobalVariables.playerDefHeight, 0);
        anim = GetComponent<Animator>();
        anim.ResetTrigger("TriggerHurt");
    }
    
    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(VerticalMovementScript.verticalPos, JumperScript.height, 0);

        if (playerHp <= 0 && alive)
        {
            print("u ded sun");
            alive = false;
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

    void OnCollisionEnter(Collision col)
    {
        if (invul == false && alive)
        {
            playerHp -= 1;
            print("Lel feg u ist das homo" + playerHp);
            CollisionInvul();
            MoonScript.setTime();
            anim.SetTrigger("TriggerHurt");
        }
    }

    void CollisionInvul()
    {
        invul = true;
        invultime = 30;
    }

}

