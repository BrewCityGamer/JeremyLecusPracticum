using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Analytics;
using UnityEngine.UI;

public class TestAdvIntegration : MonoBehaviour
{
    int totalPotions = 5;
    int totalCoins = 325;
    string weaponID = "Weapon_102";
    Text analytics;

    void Sart()
    {
        analytics = GetComponent<Text>();
    }

    void OnMouseUp()
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

        analytics.text = "Coins:" + totalCoins;

    }
}
