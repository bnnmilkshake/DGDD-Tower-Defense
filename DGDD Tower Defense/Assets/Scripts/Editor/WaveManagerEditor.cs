using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditorInternal; 


[CustomEditor(typeof(WaveManager))]
public class WaveManagerEditor : UnityEditor.Editor
{
    WaveManager db;

    private void OnEnable()
    {
        db = (WaveManager)target;
    }


    public override void OnInspectorGUI()
    {
        GUILayout.Label("Total Waves: " + db.waves.Count);
        if (GUILayout.Button("Add Wave"))
            AddWave();

        for(int i = 0; i < db.waves.Count; i++)
        {
            db.waves[i].unityName = "Wave " + i;
        }

        GUILayout.Space(10);
        //ShowArrayProperty(serializedObject.FindProperty("wavePlanner"));

        base.OnInspectorGUI();
        
    }
    public void ShowArrayProperty(UnityEditor.SerializedProperty list)
    {
        //EditorGUI.indentLevel += 1;
        for (int i = 0; i < list.arraySize; i++)
        {
            //EditorGUILayout.PropertyField(list.GetArrayElementAtIndex(i), new GUIContent("Wave" + (i + 1).ToString()));
            
        }
        //EditorGUI.indentLevel -= 1;
    }

    void AddWave()
    {
        db.waves.Add(new Wave());
    }

    void RemoveAlignment()
    {

    }

    
}
