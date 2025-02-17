using UnityEngine;
using UnityEngine.Events;

namespace Achievements
{
    public class AchievementsManager : MonoBehaviour
    {
        [SerializeField] AchievementDatabase m_Database;
        
        public UnityEvent<AchievementData> onComplete;

#if UNITY_EDITOR
        // TEST only
        [SerializeField] AchievementData[] TESTDATA;
        int index;
#endif

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

#if UNITY_EDITOR
        // TEST only - Called by button
        public void CompleteTest()
        {
            TESTDATA[index]?.Complete();
            index++;
        }
#endif
    }
}
