﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// draws a bar that represents the player's popularity
/// </summary>
public class PopBar : MonoBehaviour
{
    public float x, y;              //position coords of the bar-element

    public GUIStyle MyGUIStyle;     //allows for custom GUIoptions in editor

    /// <summary>
    /// Draw/Render loop for all GUI-elements
    /// </summary>
    private void OnGUI()
    {
        //draws a Box-element which width is determined by the NS' money
        GUI.Box(new Rect(x, y, 0.1f * Screen.width * (float)(Economy.popularity / Economy.startPop), 0.1f * Screen.height), "PopBar", MyGUIStyle);
    }
}