using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    private string textContent = "Sphere";

    public static string sphereColor
    {
        get
        {
            return "Biege";
        }
        set => sphereColor = value;
    }
    protected override void DisplayText()
    {
        base.DisplayText();
        text.text += textContent;
    }
}
