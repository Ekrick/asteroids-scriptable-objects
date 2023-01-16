using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;
using UnityEditor.UIElements;
using Variables;

[CustomPropertyDrawer(typeof(PlayManager))]
public class FloatVariableEditor : PropertyDrawer
{
    public override VisualElement CreatePropertyGUI(SerializedProperty property)
    {
        var root = new VisualElement();
        
        var floatField = new PropertyField(property.FindPropertyRelative("_value"));
        root.Add(floatField);

        var floatInspector = new Box();
        root.Add(floatInspector);
        
        floatField.RegisterCallback<ChangeEvent<SerializedObject>, VisualElement>(ValueChanged, floatInspector);
        
        return root;
    }

    void ValueChanged(ChangeEvent<UnityEditor.SerializedObject> evt, VisualElement floatInspector)
    {
        floatInspector.Clear();

        var t = evt.newValue;
        if (t == null)
            return;
        floatInspector.Add(new InspectorElement(t));
    }

}
