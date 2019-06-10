using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(EfectoDisparo))]
public class EfectoDisparoEditor : Editor
{
    public override void OnInspectorGUI(){
        DrawDefaultInspector();


        Color old = GUI.color;
        GUI.color = Color.green; // cambia color del boton


        if(GUILayout.Button("Disparar", GUILayout.Height(50))){
            (target as EfectoDisparo).Disparar();
        }
        GUI.color = old;
    }
}
