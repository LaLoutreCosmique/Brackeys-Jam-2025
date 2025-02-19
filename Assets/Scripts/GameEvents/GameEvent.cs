using Achievements;
using UnityEngine;
using UnityEngine.Events;

namespace GameEvents
{
    public abstract class GameEvent : MonoBehaviour
    {
        [SerializeField] AchievementData achievement;
        [SerializeField] UnityEvent onComplete;
        
        public AchievementData Achievement => achievement;
        
        public abstract void StartEvent();
        
        protected void CompleteEvent()
        {
            Achievement.Complete();
            onComplete?.Invoke();
        }

        public void DisplayOnTV(Sprite img)
        {
            Television.Instance.m_TvScreen.sprite = img;
        }
    }
}
