using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

public class CustomEditorWindow : EditorWindow
{
    private GameObject deathZone;

    private Transform spawnPointScript;
    
    private int nbSceneReload;
   [MenuItem("Window/Custom Editor")]
   public static void ShowWindow()
   {
      GetWindow<CustomEditorWindow>("GameObject Create");
   }
   
   private void OnGUI()
   {
       GUILayout.Label("GameObject Create", EditorStyles.boldLabel);
       
       spawnPointScript = (Transform) EditorGUILayout.ObjectField("SpawnPoint for Script", spawnPointScript, typeof(Transform), true);
      nbSceneReload = EditorGUILayout.IntField("Number of the Scene to reload when player die from deathZone", nbSceneReload);
      
      if (GUILayout.Button("Create DeathZone"))
      {
         CreateObject();
      }
   }

   void CreateObject()
   {
      deathZone =  new GameObject("DeathZone");
      deathZone.AddComponent<BoxCollider2D>();
      deathZone.AddComponent<Respawn>();
      deathZone.GetComponent<Respawn>().respawn = spawnPointScript;
      deathZone.GetComponent<Respawn>().sceneNumber = nbSceneReload;
   }
}
