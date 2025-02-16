using TMPro;
using UnityEngine;

public class Discussions : MonoBehaviour
{
    
    [SerializeField] private TextMeshProUGUI discussionText;
    [SerializeField] private TextMeshProUGUI answerText1;
    [SerializeField] private TextMeshProUGUI answerText2;
    [SerializeField] private TextMeshProUGUI answerText3;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        discussionText.gameObject.SetActive(false);
        answerText1.gameObject.SetActive(false);
        answerText2.gameObject.SetActive(false);
        answerText3.gameObject.SetActive(false);
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
        answerText3.gameObject.SetActive(true);
    }
}
