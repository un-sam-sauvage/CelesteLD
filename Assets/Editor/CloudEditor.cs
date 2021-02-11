using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Cloud))]
public class CloudEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Cloud cloud = (Cloud)target;
        
        GUILayout.BeginHorizontal();
        
        if (GUILayout.Button("Change Color"))
        {
            cloud.GenerateColor();
        }
        if (GUILayout.Button("Reset"))
        {
            cloud.Reset();
        }
        GUILayout.EndHorizontal();
    }
}
