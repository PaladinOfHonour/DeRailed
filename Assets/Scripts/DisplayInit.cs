using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayInit : MonoBehaviour {
    /// <summary>
    /// Initiatez all used displays
    /// </summary>
	void Start ()
    {
        for (int i = 0; i < Display.displays.Length; i++)
        {
            Display.displays[i].Activate();
        }
        Debug.Log("Displays Active: " + Display.displays.Length);   //Logs activated displays
	}
}
