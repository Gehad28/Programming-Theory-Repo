using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Shape : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameObject _canvas;
    private void Start()
    {
        
    }

    protected virtual void DisplayText()
    {
        text.text = "This shape is: ";
    }

    private void OnMouseDown()
    {
        DisplayText();
        _canvas.GetComponent<Canvas>().displayColor(gameObject.name);
    }
}
