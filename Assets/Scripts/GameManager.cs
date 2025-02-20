using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class GameManager : MonoBehaviour
{
    public void SetLang(Locale loc)
    {
        LocalizationSettings.SelectedLocale = loc;
    }
}
