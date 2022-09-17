using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Text.RegularExpressions;
using UnityEngine.UI;
using TMPro;
public class firstBoot : MonoBehaviour
{
    public bool isFirstBoot = false;
    void Awake()
    {
        // PlayerPrefs.DeleteAll();
        Time.timeScale = 1f;
        if (PlayerPrefs.GetInt("FIRSTTIMEOPENING", 1) == 1)
        {

            Debug.Log("First Time Opening");
            isFirstBoot = true;
            PlayerPrefs.DeleteAll();
            CallAllDB();
            //Set first time opening to false
            PlayerPrefs.SetInt("FIRSTTIMEOPENING", 0);

            //Do your stuff here
        }
        else
        {
            Debug.Log("NOT First Time Opening");
            isFirstBoot = false;
            //Do your stuff here
        }

    }

    private void CallAllDB()
    {
        LoadStatsData();
        LoadSkins();
        LoadGun();
    }

    public void LoadStatsData()
    {
        SecurePlayerPrefs.SetString("KilicUpgrade", "50", "password");
        SecurePlayerPrefs.SetString("PompaliTufekUpgrade", "50", "password");
        SecurePlayerPrefs.SetString("LevyeUpgrade", "50", "password");
        SecurePlayerPrefs.SetString("NinjaYildiziUpgrade", "50", "password");
        SecurePlayerPrefs.SetString("CurrentCoin", "50", "password");
        SecurePlayerPrefs.SetString("IsMusicOn", "true", "password");
        SecurePlayerPrefs.SetString("IsSoundEffectsOn", "true", "password");
    }

    public void LoadSkins()
    {
        SecurePlayerPrefs.SetString("Character0", "true", "password");
        SecurePlayerPrefs.SetString("Character1", "false", "password");
        SecurePlayerPrefs.SetString("Character2", "false", "password");
        SecurePlayerPrefs.SetString("Character3", "false", "password");
        SecurePlayerPrefs.SetString("Character4", "false", "password");
        SecurePlayerPrefs.SetString("Character5", "false", "password");
        SecurePlayerPrefs.SetString("Character6", "true", "password");
        SecurePlayerPrefs.SetString("CharacterBuy", "50", "password");

    }

    public void LoadGun(){
        SecurePlayerPrefs.SetString("PompaliTufek", "0", "password");
        SecurePlayerPrefs.SetString("Kilic", "1", "password");
        SecurePlayerPrefs.SetString("Levye", "2", "password");
        SecurePlayerPrefs.SetString("NinjaYildizi", "3", "password");
    }




}
