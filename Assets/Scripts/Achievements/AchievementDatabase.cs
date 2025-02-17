using System;
using UnityEngine;

namespace Achievements
{
    [CreateAssetMenu(menuName = "Achievements/database", fileName = "Database")]
    public class AchievementDatabase : ScriptableObject
    {
        public AchievementData[] data;

        public void ResetProgress()
        {
            foreach (var achievement in data)
            {
                achievement.ResetCompletion();
            }
        }
    }
}
