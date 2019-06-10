using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ArmaFake))]
public class ArmaFakeEditor : Editor
{
    public override void OnInspectorGUI() {
        DrawDefaultInspector();

        if(!Application.isPlaying)  return;
        
        GUI.color = Color.green;
        if(GUILayout.Button("Disparo simple", GUILayout.Height(40))){
            (target as ArmaFake).DisparoSimple();
        }

        if(GUILayout.Button("Disparo en rafaga", GUILayout.Height(40))){
            (target as ArmaFake).DisparoRafaga();
        }
    }
}
