using UnityEditor;
using UnityEngine;


public class Tool : EditorWindow {

    public Texture2D tex;
    // string myString = "Name of Canvas";

    int _selected = 0;

    string[] _rooms = new string[5] { "Office", "MailRoom", "Kitchen", "Computer", "Coffe" };


    [MenuItem("Window/CanvasSwitching")]

    public static void ShowWindow() {
        GetWindow<Tool>("CanvasSwitching");

    }




    private void OnGUI() {
        GUILayout.Label("Here you can see where you will go from the canvas.", EditorStyles.boldLabel);

        EditorGUI.BeginChangeCheck();

        this._selected = EditorGUILayout.Popup("Canvas", _selected, _rooms);
        tex = (Texture2D)EditorGUILayout.ObjectField(tex, typeof(Texture2D));
        if(EditorGUI.EndChangeCheck()) {
            Debug.Log(_rooms[_selected]);
        }


        GUI.DrawTexture(EditorGUILayout.GetControlRect(), tex, ScaleMode.ScaleAndCrop, true, 10.0F);
        //GUI.Label(new Rect(15, 15, cpu.width, cpu.height), cpu);

        //myString = EditorGUILayout.TextField("Canvas",myString);

        if(GUILayout.Button("Check")) {
            check();
        }
    }
    void check() {
        Debug.Log("dymy");
    }

}
