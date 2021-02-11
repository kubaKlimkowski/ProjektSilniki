using UnityEditor;
using UnityEngine;


public class Tool : EditorWindow {
    
    int _selected = 0;
    string[] _rooms = new string[5] { "Office", "MailRoom", "Kitchen", "Computer", "Coffe" };
    string from;
    string[] to;
  
    
    [MenuItem("Window/CanvasTransition")]
    public static void ShowWindow() {
        GetWindow<Tool>("CanvasTransition");

    }
    private void OnGUI() {
        GUILayout.Label("Here you can see where you will go from the canvas.", EditorStyles.boldLabel);

        EditorGUI.BeginChangeCheck();

        this._selected = EditorGUILayout.Popup("Canvas", _selected, _rooms);


        if (EditorGUI.EndChangeCheck()) {
            Debug.Log(_rooms[_selected]);
        }

        if (GUILayout.Button("Check")) {
            check();
        }

        GUILayout.Label("From: " + from, EditorStyles.boldLabel);
        for (int i = 0; i < to.Length; i++)
        {
            GUILayout.Label("To: " + to[i], EditorStyles.boldLabel);
        }
        
        

    }
    void check() {
        string room = _rooms[_selected];
        TransitionData data = Resources.Load<TransitionData>(room);
        to = new string[data.to.Count];
        for(int i = 0; i < to.Length; i++)
        {
            to[i] = data.to[i];
        }
        from = data.from;
       // Debug.Log(data.from);
    }
    

}
