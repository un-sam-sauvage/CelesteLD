using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

public class CustomEditorWindow : EditorWindow
{
  private Object deathZone = new GameObject("DeathZone");

  private Vector2 _pos;
  private Object _spawnPoint_Script;
 
   [MenuItem("Window/Custom Editor")]
   public static void ShowWindow()
   {
      GetWindow<CustomEditorWindow>("GameObject Create");
   }
   
   private void OnGUI()
   {
      GUILayout.Label("GameObject Create", EditorStyles.boldLabel);

      deathZone = EditorGUILayout.ObjectField("DeathZone", deathZone, typeof(GameObject), true);
     
      _pos = EditorGUILayout.Vector2Field("Position of GameObject", _pos);

      
     EditorGUILayout.ObjectField("SpawnPoint for Script", _spawnPoint_Script, typeof(Transform), true);
      
      if (GUILayout.Button("Create DeathZone"))
      {
         CreateObject();
      }
   }

   void CreateObject()
   {
    GameObject gameObject = new GameObject("DeathZone");
    gameObject.AddComponent<BoxCollider2D>();
    gameObject.AddComponent<Respawn>();

   }
}
