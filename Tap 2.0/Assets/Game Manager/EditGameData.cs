using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class GameDataEditor : Editor
{
 public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GameData e = target as GameData;

        if (GUILayout.Button("Reset"))
        {
            e.ResetData();
        }
    }
}
