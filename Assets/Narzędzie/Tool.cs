using UnityEditor;
using UnityEngine;

public class Tool : EditorWindow
{
    public Texture2D cpu;
    //string myString = "Name of Canvas";

    [MenuItem("Window/CanvasSwitching")]
    public static void ShowWindow()
    {
        GetWindow<Tool>("CanvasSwitching");

    }
    private void OnGUI()
    {
        GUILayout.Label("Here you can see where you will go from the canvas.", EditorStyles.boldLabel);
        GUI.Label(new Rect(15, 15, cpu.width, cpu.height), cpu);

        // myString = EditorGUILayout.TextField("Canvas", myString);

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
