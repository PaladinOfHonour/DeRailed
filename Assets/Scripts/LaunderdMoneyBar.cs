using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// draws a bar that represents the player's laundred money
/// </summary>
public class LaunderdMoneyBar : MonoBehaviour
{
    public float x, y;              //position coords of the bar-element

    public GUIStyle MyGUIStyle;     //allows for custom GUIoptions in editor

    /// <summary>
    /// Draw/Render loop for all GUI-elements
    /// </summary>
    private void OnGUI()
    {
        //draws a Box-element which width is determined by the player's laundred money
        GUI.Box(new Rect(x, y, 0.1f * Screen.width * (float)(Economy.launderedMoney / Economy.startMoney), 0.1f * Screen.height), "LaunderedBar", MyGUIStyle);
    }
}
