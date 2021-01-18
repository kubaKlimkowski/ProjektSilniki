using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

[CustomEditor(typeof(TransitionButton))]
public class TransitionButtonEditor : Editor {


    int selected = 0;
    List<string> rooms;

    private void OnEnable() {
        rooms = Resources.Load<TransitionData>((target as MonoBehaviour).transform.parent.gameObject.name).to;
        selected = rooms.IndexOf((target as TransitionButton).level);
    }

    public override void OnInspectorGUI() {

        EditorGUI.BeginChangeCheck();

        this.selected = EditorGUILayout.Popup("Canvas", selected, rooms.ToArray());

        if(EditorGUI.EndChangeCheck()) {
            (target as TransitionButton).level = rooms[selected];
            SerializedProperty prop = serializedObject.FindProperty("level");
            prop.stringValue = rooms[selected];
            serializedObject.ApplyModifiedProperties();

            Debug.Log(rooms[selected]);
        }
    }
}
