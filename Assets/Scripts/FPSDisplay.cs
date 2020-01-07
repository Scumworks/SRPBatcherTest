using UnityEngine;
using System.Collections;

public class FPSDisplay : MonoBehaviour {
    float deltaTime = 0.0f;
    int w, h;
    GUIStyle style = new GUIStyle();
    Rect rect;
    float msec, fps;
    string text;

    private void Start()
    {
        rect = new Rect(0, 0, w, h * 2 / 100);
        w = Screen.width;
        h = Screen.height;
    }


    void Update() {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
    }

    void OnGUI() {
        style.alignment = TextAnchor.UpperLeft;
        style.fontSize = h * 2 / 50;
        style.normal.textColor = Color.red;
        msec = deltaTime * 1000.0f;
        fps = 1.0f / deltaTime;
        text = string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps);
        GUI.Label(rect, text, style);
    }
}