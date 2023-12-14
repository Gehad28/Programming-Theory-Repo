using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// INHERITANCE
public class Capsule : Shape
{
    private string textContent = "Capsule";
    
    
    // ENCAPSULATION
    public static string capsuleColor
    {
        get
        {
            return "Kashmir";
        }
        set => capsuleColor = value;
    }
    
    // POLYMORPHISM
    protected override void DisplayText()
    {
        base.DisplayText();
        text.text += textContent;
    }
    
    
}
