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
        
    void OnMouseEnter()
    {
        //change text color
        renderer.material.color = hoverColor;
    }

    void OnMouseExit(){
        //change text color
        renderer.material.color = defColor;
    }

    void OnMouseDown()
    {
        if (isQuit)
        {
            Application.Quit();
        } else
        {
            Application.LoadLevel(1);
        }
    }

}
