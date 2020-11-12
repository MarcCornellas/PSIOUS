using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System.Text;

public class ReadAndCheck : EditorWindow
{
    [MenuItem("PSIOUS/CheckFiles")]

    //public GameObject recallTextObject;
    public static void ShowWindow()
    {
        GetWindow<ReadAndCheck>("CheckFiles");
    }
 

    void OnGUI()
    {
        GUILayout.Label("PSIOUS", EditorStyles.boldLabel);

        if(GUILayout.Button("CheckFiles"))
        {
            ReadFile();
        }
    }

    void ReadFile()
    {
        string readFromFilePath = Application.dataPath + "/txt_Doc/DirectoriesPsious.txt"; 
        string[] readText = File.ReadAllLines(readFromFilePath);

        foreach (string line in readText)
        {
            if(line != "Assets")
            {
                if (!Directory.Exists(Application.dataPath + "/" + line))
                    Debug.Log("No existe este fichero: " + line);
            }
        }
    }
}
