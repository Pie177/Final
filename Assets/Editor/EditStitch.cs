using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EditStitch : EditorWindow {

    public Stitch myStitch;

    public void Init(Stitch stitch)
    {
        myStitch = stitch;
    }

    private void OnGUI()
    {
        myStitch.stitchName = EditorGUILayout.TextField("Stitch Name", myStitch.stitchName);

        myStitch.summary = EditorGUILayout.TextField("Summary", myStitch.summary);

        myStitch.background = (Sprite)EditorGUILayout.ObjectField("Background",myStitch.background, typeof(Sprite), true) as Sprite;

        ScriptableObject stitch = myStitch;
        SerializedObject so = new SerializedObject(stitch);
        SerializedProperty performers = so.FindProperty("performers");
        EditorGUILayout.PropertyField(performers, true);
        so.ApplyModifiedProperties();
        
    }
}
