using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// INHERITANCE
public class Cube : Shape
{
    private string textContent = "Cube";
    
    
    // ENCAPSULATION
    public static string cubeColor
    {
        get
        {
            return "Dark Cyan";
        }
        set => cubeColor = value;
    }
    
    // POLYMORPHISM
    protected override void DisplayText()
    {
        base.DisplayText();
        text.text += textContent;
    }

}
