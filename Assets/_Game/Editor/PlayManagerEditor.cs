using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;
using UnityEditor.UIElements;

[CustomEditor(typeof(PlayManager))]
public class PlayManagerEditor : Editor
{
    public VisualTreeAsset _editorUXML;
    public override VisualElement CreateInspectorGUI()
    {
        var root = new VisualElement();
        _editorUXML.CloneTree(root);

        var foldout = new Foldout() { viewDataKey = "PlayManagerFullInspectorFoldout", text = "Full Inspector" };
        InspectorElement.FillDefaultInspector(foldout, serializedObject, this);
        root.Add(foldout);
        return root;
    }
}
