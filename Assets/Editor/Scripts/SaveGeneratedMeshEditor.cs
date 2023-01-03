using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SaveGeneratedMesh))]
public class SaveGeneratedMeshEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        SaveGeneratedMesh myScript = (SaveGeneratedMesh)target;
        if(GUILayout.Button(new GUIContent("Save Mesh to Assets", "Instantiating mesh during edit mode will leak meshes. Please don't forget to do this action in Play Mode")))
        {
            myScript.SaveAsset();
        }
    }
}
