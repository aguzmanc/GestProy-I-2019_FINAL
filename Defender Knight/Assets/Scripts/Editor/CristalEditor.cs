using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Cristal))]
public class CristalEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        Cristal cristal = target as Cristal;

        if (GUILayout.Button("74"))
            cristal.VidaCristal = 75;

        if (GUILayout.Button("49"))
            cristal.VidaCristal = 50;

        if (GUILayout.Button("24"))
            cristal.VidaCristal = 25;

        if (GUILayout.Button("4"))
            cristal.VidaCristal = 5;

    }
}
