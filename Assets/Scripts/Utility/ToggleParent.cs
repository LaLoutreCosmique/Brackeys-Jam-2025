using System;
using System.Collections.Generic;
using UnityEngine;

namespace Utility
{
    public class ToggleParent : MonoBehaviour
    {
        List<ClickableObject> m_ClickObjects = new ();

        void Start()
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                var comp = transform.GetChild(i).GetComponent<ClickableObject>();
                if (comp == null) continue;
                
                comp.onClick.AddListener(SetToggle);
                m_ClickObjects.Add(comp);
            }
        }

        void SetToggle(ClickableObject obj)
        {
            foreach (var clickObject in m_ClickObjects)
            {
                if (clickObject == obj)
                    clickObject.Activate();
                else
                    clickObject.Deactivate();
            }
        }
    }
}
