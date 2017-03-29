using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyBar : MonoBehaviour
{
    public GUIStyle MyGUIStyle;

    private void OnGUI()
    {
        GUI.Box(new Rect(100, 100, 0.1f * Screen.width * (float)(Economy.money / Economy.startMoney), 0.1f * Screen.height), "MoneyBar", MyGUIStyle);
    }
}
