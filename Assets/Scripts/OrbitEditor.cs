using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Orbit))]
public class OrbitEditor : Editor
{
    public override void OnInspectorGUI()
    {
        

        EditorGUILayout.Space();
        var orbit = (Orbit)target;
        
        if(GUILayout.Button("Generate"))
        {
            orbit.Generate();
            EditorUtility.SetDirty(orbit);
        }
        DrawDefaultInspector();
        
    }
}