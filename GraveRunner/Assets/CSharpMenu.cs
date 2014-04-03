using UnityEngine;
using System.Collections;

public class CSharpMenu : MonoBehaviour
{

    public Color defColor;
    public Color hoverColor;

    void Start(){
        defColor = this.renderer.material.color;
    }

    public bool isQuit;
    public bool quitToMenu;
    public bool playAgain;
        
    void OnMouseEnter()
    {
        //change text color
        //renderer.material.color = hoverColor;
    }

    void OnMouseExit(){
        //change text color
        renderer.material.color = defColor;
    }

    void OnMouseDown()
    {
        if(quitToMenu)
        {
            Application.LoadLevel("Main Menu");
        }
        else if(playAgain){
            GlobalVariables.ResetLevel();
            Application.LoadLevel(1);
        }
        else if (isQuit)
        {
            Application.Quit();
        } 
        else
        {
            Application.LoadLevel(1);
        }
    }

}
