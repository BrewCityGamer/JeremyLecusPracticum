using UnityEngine;
using UnityEngine.Advertisements;
using System.Collections;

public class UnityAdsExample : MonoBehaviour
{
    public void ShowAd()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
}
