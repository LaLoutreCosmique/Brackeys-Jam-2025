using Achievements;
using UnityEngine;

namespace GameEvents
{
    public abstract class GameEvent : MonoBehaviour
    {
        [SerializeField] AchievementData achievement;

        public AchievementData Achievement => achievement;
        
        public abstract void StartEvent();
    }
}
