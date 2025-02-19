using UnityEngine;

namespace GameEvents
{
    public class PopupEvent : GameEvent
    {
        public override void StartEvent()
        {
            Achievement.Complete();
        }
    }
}
