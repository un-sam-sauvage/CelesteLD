using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EditorWindows : EditorWindow
{
    private Object gameObject;
    private Vector2 position;
    
    [MenuItem("Window/Instantiate")]
    public static void ShowWindow()
    {
        GetWindow<EditorWindows>("Instantiate");
    }
    
    void OnGUI()
    {
        GUILayout.Label("Select the good Object to instantiate", EditorStyles.boldLabel);

        gameObject = EditorGUILayout.ObjectField(gameObject, typeof(GameObject), false);
        position.x = EditorGUILayout.FloatField("The x position :",position.x);
        position.y = EditorGUILayout.FloatField("The y position :",position.y);
        
        if (GUILayout.Button("Instantiate this object"))
        {
            Instantiate(gameObject, position, Quaternion.identity);
        }
    }
}
