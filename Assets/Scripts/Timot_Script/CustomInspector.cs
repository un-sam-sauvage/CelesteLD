using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(RespawnPikes))]
[CanEditMultipleObjects]
public class CustomInspector : Editor
{
    public override void OnInspectorGUI()
    {
       base.OnInspectorGUI();
        RespawnPikes pikes = (RespawnPikes)target;
        
        GUILayout.BeginHorizontal();
        
        if (GUILayout.Button("Clear RespawnPoint"))
        {
            pikes.ClearRespawnPoint();
        }

        if (GUILayout.Button("Add SpawnPoint"))
        {
            pikes.AddRespawnPoint();
        }
        
        GUILayout.EndHorizontal();
    }
}