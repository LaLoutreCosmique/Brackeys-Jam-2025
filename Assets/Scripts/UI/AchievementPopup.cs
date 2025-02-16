using Achievements;
using TMPro;
using UnityEngine;

namespace UI
{
    public class AchievementPopup : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI title;
        [SerializeField] TextMeshProUGUI description;
        
        public void Activate(AchievementData data)
        {
            title.text = data.title.GetLocalizedString();
            description.text = data.description.GetLocalizedString();
        }
    }
}
