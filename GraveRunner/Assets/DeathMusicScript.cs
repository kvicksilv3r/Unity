using UnityEngine;
using System.Collections;

public class DeathMusicScript : MonoBehaviour {


    public bool checkIfDead = true;

	// Use this for initialization
	void Start () {
        checkIfDead = true;
        audio.Stop();
	}
	
	// Update is called once per frame
	void Update () {
	
        if(checkIfDead)
        {
            if(!PlayerScript.alive)
            {
                audio.Play();
                checkIfDead = false;
            }
        }

	}
}
