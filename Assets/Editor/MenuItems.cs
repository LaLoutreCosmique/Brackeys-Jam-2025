using Achievements;
using UnityEditor;
using UnityEngine;

public class MenuItems
{
    [MenuItem("Tools/Reset Achievements")]
    static void ResetAchievements()
    {
        try
        {
            AssetDatabase.LoadAssetAtPath<AchievementDatabase>("Assets/Data/Achievements/Database.asset").ResetProgress();
            Debug.Log("<color=green>Les succès ont bien été reset, à toi de jouer champion.</color>");
        }
        catch
        {
            Debug.LogWarning("Eh chef il manque le AchievementDatabase à : Assets/Data/Achievements/Database.asset.");
        }
    }
}

