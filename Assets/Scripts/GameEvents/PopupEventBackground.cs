using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

namespace GameEvents
{
    public class PopupEventBackground : MonoBehaviour, IPointerClickHandler
    {
        public static PopupEventBackground Instance { get; private set; }
        
        SpriteRenderer m_Sprite;
        BoxCollider2D m_Collider;

        PopupEvent m_Popup;

        void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
            }
            else
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            
            m_Sprite = GetComponent<SpriteRenderer>();
            m_Collider = GetComponent<BoxCollider2D>();
        }
        
        void OnDestroy()
        {
            if (Instance == this)
            {
                Instance = null;
            }
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            Hide();
        }

        public void Show(PopupEvent popup)
        {
            m_Popup = popup;
            m_Collider.enabled = true;
            m_Sprite.DOFade(0.5f, 0.5f);
        }

        void Hide()
        {
            if (!m_Popup.Hide()) return;
            
            m_Collider.enabled = false;
            m_Sprite.DOFade(0f, 0.5f);
        }
    }
}
