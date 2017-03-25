using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    

public class PopUpW : MonoBehaviour {
    private Rect popUpRect;
    public Canvas canvas;
    public Vector2 origin;
    public int width, height;
    public string message, title;
    
	void Start () {
        origin = gameObject.GetComponent<RectTransform>().anchoredPosition;
        //GUI.transform.SetParent(canvas.transform);
        Debug.Log("Hellow World");        
    }

    void OnGUI()
    {
        GUI.Window(0, popUpRect, PopUp, title);
    }

    void PopUp(int id)
    {
        popUpRect = new Rect(origin, new Vector2());
        Debug.Log(popUpRect);
        if (GUI.Button(popUpRect, message)) Debug.Log("YATTA");
    }
}
