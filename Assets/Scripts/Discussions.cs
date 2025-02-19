using System;
using GameEvents;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Discussions : GameEvent
{
    
    [SerializeField] private TextMeshProUGUI discussionText;
    [SerializeField] private Button answerText1;
    [SerializeField] private Button answerText2;
    //[SerializeField] private TextMeshProUGUI answerText3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //discussionText.gameObject.SetActive(false);
        //answerText1.gameObject.SetActive(false);
        //answerText2.gameObject.SetActive(false);
        //answerText3.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DiscussionWith2Answers()
    {
        discussionText.gameObject.SetActive(true);
        answerText1.gameObject.SetActive(true);
        answerText2.gameObject.SetActive(true);
    }

    void DiscussionWith3Answers()
    {
        DiscussionWith2Answers();
        //answerText3.gameObject.SetActive(true);
    }

    public void ShowDiscussion(DialoguePart dialoguePart)
    {
        Debug.Log(dialoguePart.answers.Length);
        if (dialoguePart.answers.Length == 1)
        {
            Debug.Log("a");
            if (dialoguePart.answers[0].achievements != null)
            {
                dialoguePart.answers[0].achievements.Complete();
            }
            StopDiscussion();
            return;
        }
        discussionText.text = dialoguePart.discussionText.GetLocalizedString();
        answerText1.GetComponentInChildren<TextMeshProUGUI>().text = dialoguePart.answers[0].answerText.GetLocalizedString();
        answerText2.GetComponentInChildren<TextMeshProUGUI>().text = dialoguePart.answers[1].answerText.GetLocalizedString();
        DiscussionWith2Answers();
    }
    

    public void StopDiscussion()
    {
        discussionText.gameObject.SetActive(false);
        answerText1.gameObject.SetActive(false);
        answerText2.gameObject.SetActive(false);
    }

    public override void StartEvent()
    {
        
    }
}
