using Achievements;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(AchievementDatabase))]
public class AchievementDatabase_Editor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        AchievementDatabase database = (AchievementDatabase)target;

        if (GUILayout.Button("Reset progress"))
        {
            database.ResetProgress();
            Debug.Log("All achievements have been reset");
        }
    }
}