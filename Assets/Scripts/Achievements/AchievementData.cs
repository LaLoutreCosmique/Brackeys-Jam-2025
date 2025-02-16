using UnityEngine;
using UnityEngine.Localization;

namespace Achievements
{
    [CreateAssetMenu(menuName = "Achievements/data", fileName = "New Achievement")]
    public class AchievementData : ScriptableObject
    {
        public delegate void CompletedDelegate(AchievementData achievement);
        CompletedDelegate m_CompletedCallback;
        
        public LocalizedString title;
        public LocalizedString description;
        public Sprite completedImage;
        public Sprite uncompletedImage;

        bool m_Completed;
        public bool Completed => m_Completed;

        public void Complete()
        {
            if (m_Completed) return;

            m_Completed = true;
            m_CompletedCallback.Invoke(this);
        }

        public void SetCompletedCallback(CompletedDelegate callback)
        {
            m_CompletedCallback = callback;
        }
    }
}
