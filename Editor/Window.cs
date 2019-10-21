using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Window : EditorWindow
{
    [MenuItem("Window/Example")]
    static void Open()
    {
        var exampleWindow = CreateInstance<Window>();
        exampleWindow.Show();
    }
}
