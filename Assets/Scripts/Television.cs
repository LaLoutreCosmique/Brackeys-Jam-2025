using System;
using UnityEngine;

public class Television : MonoBehaviour
{
    public static Television Instance { get; private set; }
    
    [HideInInspector] public SpriteRenderer m_TvScreen;

    void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(gameObject);
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        
        m_TvScreen = GetComponent<SpriteRenderer>();
    }
}
