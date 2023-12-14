using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// INHERITANCE
public class Sphere : Shape
{
    private string textContent = "Sphere";
    
    
    // ENCAPSULATION
    public static string sphereColor
    {
        get
        {
            return "Biege";
        }
        set => sphereColor = value;
    }
    
    // POLYMORPHISM
    protected override void DisplayText()
    {
        base.DisplayText();
        text.text += textContent;
    }
}
