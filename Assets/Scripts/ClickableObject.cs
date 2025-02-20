using GameEvents;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

[RequireComponent(typeof(PolygonCollider2D))]
public class ClickableObject : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    [SerializeField] Sprite initialSprite;
    [SerializeField] Sprite hoveredSprite;
    [SerializeField] GameEvent gameEvent;
    
    public UnityEvent<ClickableObject> onClick;

    SpriteRenderer m_Renderer;
    bool m_MouseInside, active;

    void Awake()
    {
        m_Renderer = GetComponent<SpriteRenderer>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (gameEvent != null && gameEvent.Achievement.Completed) return;
        
        m_MouseInside = true;

        if (hoveredSprite != null)
            m_Renderer.sprite = hoveredSprite;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (!m_MouseInside || active) return;
        
        m_MouseInside = false;

        if (hoveredSprite != null)
            m_Renderer.sprite = initialSprite;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!m_MouseInside || active) return;
        
        if (gameEvent != null) gameEvent.StartEvent();
        onClick?.Invoke(this);
    }

    public void Activate()
    {
        m_Renderer.sprite = hoveredSprite;
        active = true;
    }

    public void Deactivate()
    {
        m_Renderer.sprite = initialSprite;
        active = false;
    }
}
