using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape
{
    private string textContent = "Capsule";

    public static string capsuleColor
    {
        get
        {
            return "Kashmir";
        }
        set => capsuleColor = value;
    }
    protected override void DisplayText()
    {
        base.DisplayText();
        text.text += textContent;
    }
    
    
}
