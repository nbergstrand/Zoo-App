using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class AnalyticsEvent : MonoBehaviour
{
    public void OnButtonClicked(string eventInfo)
    {
        Analytics.CustomEvent(eventInfo);
    }
}
