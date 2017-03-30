using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// draws a bar that represents the NS' money
/// </summary>
public class MoneyBar : MonoBehaviour
{
    public float x, y;              //position coords of the bar-element
    public string text;             //leave empty for no text in the bar
    public float widthMax;          //Max width the bar can grow; Leave Empty for no Cap
    private float width;
    private string oldText;

    public GUIStyle MyGUIStyle;     //allows for custom GUIoptions in editor

    void Update()
    {
        width = 0.1f * Screen.width * (float)(Economy.money / Economy.startMoney);
        if (width >= widthMax && text == "")
        {
            width = widthMax;
            oldText = text;
            text = "Max";
            return;
        }
        else if (width >= widthMax)
        {
            width = widthMax;
            return;
        }

        text = oldText;                  //if not max size: reset text to previous
    }

    /// <summary>
    /// Draw/Render loop for all GUI-elements
    /// </summary>
    private void OnGUI()
    {
        //draws a Box-element which width is determined by the NS' money
        GUI.color = Color.green;
        GUI.Box(new Rect(x, y, width, 0.1f * Screen.height), text, MyGUIStyle);
    }
}

