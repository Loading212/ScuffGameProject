using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float deltaTime;
    private GUIStyle style;

    // Start is called before the first frame update
    void Start()
    {
        style = new GUIStyle();
        style.fontSize = 30;
        style.normal.textColor = Color.white;

    }

    // Update is called once per frame
    void Update()
    {
        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
    }

    private void OnGui()
    {
        int fps = (int)(1.0f / deltaTime);
        Rect rect = new Rect(10, 10, 200, 50);
        GUI.Label(rect, "FPS: " + fps, style);
    }
}

