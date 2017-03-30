using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Displays the economy values in numbers
/// </summary>
public class EconomyValues : MonoBehaviour
{
    public float x, y, width, height, offsetx, offsety;
    public bool def;                                //true = default layout

    //allows for GUI customizibility in Editor
    public GUIStyle MyGuiStyle;

    /// <summary>
    /// initializes vars before OnGui is first called
    /// </summary>
    private void Start()
    {
        if (def) offsety = MyGuiStyle.fontSize;     //set's default offset; default all three vars are lined up vertically
    }

    /// <summary>
    /// Draw/Render loop for all GUI-elements
    /// </summary>
    void OnGUI()
    {
        GUI.Label(new Rect(x, y, width, height), ((int)Economy.popularity).ToString(), MyGuiStyle);
        GUI.Label(new Rect(x + offsetx, y + offsety, width, height), ((int)Economy.money).ToString(), MyGuiStyle);
        GUI.Label(new Rect(x + 2 * offsetx, y + 2 * offsety, width, height), ((int)Economy.launderedMoney).ToString(), MyGuiStyle);
    }
}