using UnityEngine;
using System.Collections;

public class PlayAgainScript : MonoBehaviour {

    public bool isQuit;

    void OnMouseDown()
    {
        if(isQuit)
        {
            Application.LoadLevel("Main Menu");
        }
        else
        {

            GlobalVariables.ResetLevel();
            Application.LoadLevel(1);
        }
    }
}
