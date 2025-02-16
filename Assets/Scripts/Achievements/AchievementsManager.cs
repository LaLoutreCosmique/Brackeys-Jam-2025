using UnityEngine;
using UnityEngine.Events;

namespace Achievements
{
    public class AchievementsManager : MonoBehaviour
    {
        [SerializeField] AchievementDatabase m_Database;
        
        public UnityEvent<AchievementData> onComplete;

        // TEST only
        [SerializeField] AchievementData TESTDATA;

        void Start()
        {
            foreach (var achievement in m_Database.data)
            {
                achievement.SetCompletedCallback(OnAchievementComplete);
            }
        }

        void OnAchievementComplete(AchievementData achievement)
        {
            onComplete.Invoke(achievement);
        }
        
        // TEST only
        public void CompleteTest()
        {
            TESTDATA.Complete();
        }
    }
}
