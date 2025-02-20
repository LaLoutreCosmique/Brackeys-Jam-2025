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
        answerText1.onClick.RemoveAllListeners();
        answerText2.onClick.RemoveAllListeners();
        discussionText.text = dialoguePart.discussionText.GetLocalizedString();
        answerText1.GetComponentInChildren<TextMeshProUGUI>().text = dialoguePart.answers[0].answerText.GetLocalizedString();
        answerText2.GetComponentInChildren<TextMeshProUGUI>().text = dialoguePart.answers[1].answerText.GetLocalizedString();
        DiscussionWith2Answers();
        if (dialoguePart.answers[0].achievements != null)
            answerText1.onClick.AddListener(delegate { dialoguePart.answers[0].achievements.Complete(); });

        if (dialoguePart.answers[1].achievements != null)
            answerText2.onClick.AddListener(delegate { dialoguePart.answers[1].achievements.Complete(); });
        if (dialoguePart.answers[0].text != null && dialoguePart.answers[1].text != null)
        {
            answerText1.onClick.AddListener(delegate { ShowDiscussion(dialoguePart.answers[0].text); });
            answerText2.onClick.AddListener(delegate { ShowDiscussion(dialoguePart.answers[1].text); });
        }
        else
        {
            answerText1.onClick.AddListener(StopDiscussion);
            answerText2.onClick.AddListener(StopDiscussion);
        }
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
