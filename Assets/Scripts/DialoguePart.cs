using System.Collections.Generic;
using Achievements;
using UnityEditor.Localization;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;

[CreateAssetMenu(fileName = "DialoguePart", menuName = "DialogEvent/DialogPart")]
public class DialoguePart : ScriptableObject
{
    public LocalizedString discussionText;
    public DialogueAnswer[] answers;
    
    [System.Serializable]
    public class DialogueAnswer
    {
        public LocalizedString answerText;
        public DialoguePart text;
        public AchievementData achievements;
    
    }
}


