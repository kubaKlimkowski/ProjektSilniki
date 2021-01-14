using UnityEditor;
using UnityEngine;


public class Tool : EditorWindow
{
    //public Texture2D cpu;
   // string myString = "Name of Canvas";

    int _selected = 0;
    string[] _rooms = new string[5] { "Office","MailRoom","Kitchen","Computer","Coffe" };
    

    [MenuItem("Window/CanvasSwitching")]
   
    public static void ShowWindow()
    {
        GetWindow<Tool>("CanvasSwitching");

    }

    


    private void OnGUI()
    {
        GUILayout.Label("Here you can see where you will go from the canvas.", EditorStyles.boldLabel);

        EditorGUI.BeginChangeCheck();

        this._selected = EditorGUILayout.Popup("Canvas", _selected, _rooms);

        if (EditorGUI.EndChangeCheck())
        {
            Debug.Log(_rooms[_selected]);  
        }
        

       
        //GUI.Label(new Rect(15, 15, cpu.width, cpu.height), cpu);
        
        //myString = EditorGUILayout.TextField("Canvas",myString);

        if (GUILayout.Button("Check"))
        {
            check();
        }
}
    void check()
    {
        Debug.Log("dymy");
    }

}
