using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GridGenerator))]
public class GridGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        GridGenerator gridGenerator = (GridGenerator)target;
        if (GUILayout.Button("Generate Grid"))
        {
            gridGenerator.GenerateGrid();
        }
        if (GUILayout.Button("Explode Grid"))
        {
            gridGenerator.ClearGrid();
        }
        if (GUILayout.Button("Assign Grid Material"))
        {
            gridGenerator.AssignMaterial();
        }
    }
}
