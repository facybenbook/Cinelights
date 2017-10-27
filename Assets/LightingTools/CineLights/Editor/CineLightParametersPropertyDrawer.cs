﻿using UnityEditor;
using UnityEngine;
using LightUtilities;

[CustomPropertyDrawer(typeof(CineLightParameters))]
public class CineLightParametersPropertyDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginProperty(position, label, property);

        EditorGUILayout.PropertyField(property.FindPropertyRelative("displayName"));
        EditorGUILayout.PropertyField(property.FindPropertyRelative("drawGizmo"));
        EditorLightingUtilities.DrawSplitter();

        #region Rig
        EditorGUI.indentLevel--;
        EditorLightingUtilities.DrawHeader("Rig");
        EditorGUI.indentLevel++;

        EditorGUILayout.PropertyField(property.FindPropertyRelative("linkToCameraRotation"));
        EditorGUILayout.PropertyField(property.FindPropertyRelative("Yaw"));
        EditorGUILayout.PropertyField(property.FindPropertyRelative("Pitch"));
        if (property.serializedObject.FindProperty("lightCookie") != null && property.serializedObject.FindProperty("lightCookie").objectReferenceValue != null)
        {
            EditorGUILayout.PropertyField(property.FindPropertyRelative("Roll"));
        }
        EditorGUILayout.PropertyField(property.FindPropertyRelative("distance"));
        EditorGUILayout.PropertyField(property.FindPropertyRelative("offset"));
        #endregion

        EditorGUI.EndProperty();
    }
}