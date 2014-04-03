using UnityEngine;
using System.Collections;

public class SoundScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        audio.Play();
	}
	
	// Update is called once per frame
	void Update () {

        if(this.gameObject.name == "GameCamera")
        {
            if(!PlayerScript.alive)
            {
             audio.Stop();
            }
        }
	
	}
}
