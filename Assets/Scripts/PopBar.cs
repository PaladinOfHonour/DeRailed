using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopBar : MonoBehaviour
{
    public float x, y;

    public GUIStyle MyGUIStyle;

    private void OnGUI()
    {
        GUI.Box(new Rect(x, y, 0.1f * Screen.width * (float)(Economy.popularity / Economy.startPop), 0.1f * Screen.height), "PopBar", MyGUIStyle);
    }
}