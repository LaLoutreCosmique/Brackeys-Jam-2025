using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

namespace GameEvents
{
    public class PopupEvent : GameEvent
    {
        float m_Offset = 10f;

        GameObject GO;
        bool m_IsHiding;
        
        public override void StartEvent()
        {
            GO = Instantiate(gameObject);
            GO.transform.position = Vector3.down * m_Offset;
            GO.transform.DOMove(Vector3.zero, 0.2f);
            PopupEventBackground.Instance.Show(this);
            m_IsHiding = false;
        }

        public bool Hide()
        {
            if (m_IsHiding) return false;

            m_IsHiding = true;
            GO.transform.DOMoveY(-m_Offset, 0.2f).OnComplete(() =>
            {
                Destroy(GO);
                m_IsHiding = false;
            });

            return true;
        }

        
    }
}
