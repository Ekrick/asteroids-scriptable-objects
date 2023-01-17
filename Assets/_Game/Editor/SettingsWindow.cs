using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

public class SettingsWindow : EditorWindow
{
    public SettingsManager _settings;
    public VisualTreeAsset _editorUXML;

    [MenuItem("Window/Settings")]

    static void CreateMenu()
    {
        var window = GetWindow<SettingsWindow>();
        window.titleContent = new GUIContent("Settings");
    }

    private void OnEnable()
    {
        var serObj = new SerializedObject(_settings);
        
        rootVisualElement.Bind(serObj);
    }

    private void CreateGUI()
    {
        if (_settings == null)
            return;

        _editorUXML.CloneTree(rootVisualElement);
    }
}
