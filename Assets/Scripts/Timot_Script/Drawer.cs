using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(bool))]
public class Drawer : UnityEditor.PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        //Si un boolean est true sa couleur sera verte sinon elle sera rouge
        if (property.boolValue)
        {
            //On commence a indiquer la property qu'on veux commencer à la modifier
            EditorGUI.BeginProperty(position, label, property);
            //On précise le label si il est controlable ect...
            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);
            GUI.backgroundColor = Color.green;
            //Ici on précise qu'on le contenue de la property
            EditorGUI.PropertyField(position, property, GUIContent.none);
            //Ici on précise que c'est la fin de la modification de notre property
            EditorGUI.EndProperty();
        }

        if (!property.boolValue)
        {
            //On commence a indiquer la property qu'on veux commencer à la modifier
            EditorGUI.BeginProperty(position, label, property);
            //On précise le label si il est controlable ect...
            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);
            GUI.backgroundColor = Color.red;
            //Ici on précise qu'on le contenue de la property
            EditorGUI.PropertyField(position, property, GUIContent.none);
            //Ici on précise que c'est la fin de la modification de notre property
            EditorGUI.EndProperty();
        }
    }
}
