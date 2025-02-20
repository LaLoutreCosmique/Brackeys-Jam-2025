using System;
using System.Collections;
using System.Collections.Generic;
using Achievements;
using DG.Tweening;
using TMPro;
using UnityEngine;

namespace UI
{
    public class AchievementPopup : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI title;
        [SerializeField] TextMeshProUGUI description;

        [SerializeField]RectTransform m_Rect;
        Queue<AchievementData> m_Queue = new ();
        bool m_IsDisplayed;

        void Start()
        {
            m_IsDisplayed = false;
            m_Rect = GetComponent<RectTransform>();
        }

        public void Activate(AchievementData data)
        {
            
            if (m_IsDisplayed)
            {
                m_Queue.Enqueue(data);
                return;
            }
            
            m_IsDisplayed = true;
            title.text = data.Title.GetLocalizedString();
            description.text = data.Description.GetLocalizedString();
            m_Rect.DOAnchorPosX(-m_Rect.sizeDelta.x/2, 1).OnComplete(() => StartCoroutine(Hide()));
        }

        IEnumerator Hide()
        {
            
            yield return new WaitForSeconds(2f);
            m_Rect.DOAnchorPosX(m_Rect.sizeDelta.x/2, 1).OnComplete(() =>
            {
                m_IsDisplayed = false;
                if (m_Queue.Count > 0)
                    Activate(m_Queue.Dequeue());
            });
        }
    }
}
