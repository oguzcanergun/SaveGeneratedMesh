#if UNITY_EDITOR
using System;
using UnityEngine;
using UnityEditor;

public class SaveGeneratedMesh : MonoBehaviour
{
    public string saveName = "SavedMesh";
    public MeshFilter selectedGameObject;

    public void SaveAsset()
    {
        var meshToSave = selectedGameObject.mesh;
        if (!AssetDatabase.Contains(meshToSave))
        {
            if (!EditorApplication.isPlaying)
            {
                Debug.LogWarning("Please enter Play Mode to use this function.");
                return;
            }
            var savePath = "Assets/" + saveName + DateTime.Now.ToString("ssmmddMMyyyy") + ".asset";
            AssetDatabase.CreateAsset(meshToSave, savePath);
            Debug.Log("Asset created successfully to " + savePath);
        }
        else
        {
            Debug.LogWarning("Couldn't add object to asset file because the Mesh is already an asset");
        }
        
    }
}
#endif
