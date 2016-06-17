using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Analytics;
using UnityEngine.UI;

public class AnalyticsExample : MonoBehaviour
{
    int totalPotions = 5;
    private int totalCoins = 0;
    string weaponID = "Weapon_102";
    UnityEngine.UI.Text txt;

    void Start()
    {
        txt = GetComponent<UnityEngine.UI.Text>();
        txt.text = "Coins:" + totalCoins;
    }

    public void Update()
    {
        txt.text = "Coins:" + totalCoins;
        
    }

    public void TextStats()
    {
        Analytics.Transaction("12345abcde", 0.99m, "USD", null, null);

        Gender gender = Gender.Female;
        Analytics.SetUserGender(gender);

        int birthYear = 2014;
        Analytics.SetUserBirthYear(birthYear);

        Debug.Log("Here!");
        Analytics.CustomEvent("gameOver", new Dictionary<string, object>
        {
            { "potions", totalPotions },
            { "coins", totalCoins },
            { "activeWeapon", weaponID }
        });

        totalCoins++;
        txt.text = "Coins:" + totalCoins ;
   
    }
}