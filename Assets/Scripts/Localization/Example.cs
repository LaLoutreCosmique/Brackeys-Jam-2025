using System;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;

namespace Localization
{
    public class Example : MonoBehaviour
    {
        // C'est juste un exemple pour que tu vois vite-fait

        [SerializeField] LocalizedString description;
        TextMeshProUGUI descHandler;

        void Start()
        {
            descHandler = GetComponent<TextMeshProUGUI>();
        }

        void OnEnable()
        {
            description.StringChanged += UpdateDesc;
        }

        void OnDisable()
        {
            description.StringChanged -= UpdateDesc;
        }

        void UpdateDesc(string txt)
        {
            descHandler.text = txt;
            // ou
            descHandler.text = description.GetLocalizedString();
        }
    }
}
