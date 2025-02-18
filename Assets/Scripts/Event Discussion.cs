using System.Collections.Generic;
using UnityEngine;

public class EventDiscussion : MonoBehaviour
{

    private bool isEventCompleted = false;
    private bool isOnAction =  false;
    private float timer = 0f;
    
    [SerializeField] private List<GameObject> eventDiscussion = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 100f && !isOnAction)
        {
            isOnAction = true;
        }
    }
}
