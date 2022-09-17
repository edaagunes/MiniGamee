using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject SettingsMenu;
    public GameObject StoreMenu;
    public GameObject MainMenu;

    public Button MusicButton;
    public Sprite music_on;
    public Sprite music_off;
    public Button SoundButton;
    public Sprite sound_on;
    public Sprite sound_off;

    public AudioSource themeMusic;
    public AudioSource themeSound;

    public GameObject[] pompaliTufek;
    public GameObject[] kilic;
    public GameObject[] ninjaYildizi;
    public GameObject[] levye;

    public void Awake(){
        Controller();
    }
 
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }

    public void Settings(){
        SettingsMenu.SetActive(true);
        StoreMenu.SetActive(false);
        MainMenu.SetActive(false);

    }

    public void Store(){
        StoreMenu.SetActive(true);
        MainMenu.SetActive(false);
        SettingsMenu.SetActive(false);
    }

    public void Controller(){
        string levelP = SecurePlayerPrefs.GetString("PompaliTufek","password");
        bool parselevelP=Int32.TryParse(levelP, out int levelIntP);

        for ( int i = 0; i < levelIntP; i++)
        {
          pompaliTufek[i].SetActive(true);
        }

        string levelK = SecurePlayerPrefs.GetString("Kilic","password");
        bool parselevelK=Int32.TryParse(levelK, out int levelIntK);

        for ( int i = 0; i < levelIntK; i++)
        {
          kilic[i].SetActive(true);
        }

        string levelL = SecurePlayerPrefs.GetString("Levye","password");
        bool parselevelL=Int32.TryParse(levelL, out int levelIntL);

         for (int i = 0; i < levelIntL; i++)
        {
            levye[i].SetActive(true);
        }

        string levelN = SecurePlayerPrefs.GetString("NinjaYildizi","password");
        bool parselevelN=Int32.TryParse(levelN, out int levelIntN);

        for (int i = 0; i < levelIntN; i++)
        {
            ninjaYildizi[i].SetActive(true);
         }

        //muzik kontrolu
        string musicC = SecurePlayerPrefs.GetString("IsMusicOn","password");
        bool parsemusicC = Int32.TryParse(musicC, out int mymusicC);

         if (musicC == "false")
        {
            SecurePlayerPrefs.SetString("IsMusicOn", "false", "password");
            MusicButton.GetComponent<Image>().sprite = music_off;  
            themeMusic.Pause();
            
        }
        else
        {
            SecurePlayerPrefs.SetString("IsMusicOn", "true", "password");
            MusicButton.GetComponent<Image>().sprite = music_on;  
            themeMusic.Play();
        }

        //sound kontrolu
        string soundeffectsC = SecurePlayerPrefs.GetString("IsSoundEffectsOn", "password");
        bool parsemusicS = Int32.TryParse(soundeffectsC, out int mysoundC);

        if (soundeffectsC == "false")
        {
            SecurePlayerPrefs.SetString("IsSoundEffectsOn", "false", "password");
            SoundButton.GetComponent<Image>().sprite = sound_off;  
            themeSound.Pause();  
        }
        else
        {
            SecurePlayerPrefs.SetString("IsSoundEffectsOn", "true", "password");
            SoundButton.GetComponent<Image>().sprite = sound_on;  
            themeSound.Play(); 
        }
    }

       public void MusicController(){
        
        string music = SecurePlayerPrefs.GetString("IsMusicOn","password");
        bool parsemusic = Int32.TryParse(music, out int mymusic);

         if (music == "true")
        {
            SecurePlayerPrefs.SetString("IsMusicOn", "false", "password");
            MusicButton.GetComponent<Image>().sprite = music_off;  
            themeMusic.Pause();
            
        }
        else
        {
            SecurePlayerPrefs.SetString("IsMusicOn", "true", "password");
            MusicButton.GetComponent<Image>().sprite = music_on;  
            themeMusic.Play();
        }
    } 
    public void SoundController(){

        string soundeffects = SecurePlayerPrefs.GetString("IsSoundEffectsOn", "password");
        bool parsemusic = Int32.TryParse(soundeffects, out int mysound);

        if (soundeffects == "true")
        {
            SecurePlayerPrefs.SetString("IsSoundEffectsOn", "false", "password");
            SoundButton.GetComponent<Image>().sprite = sound_off;  
            themeSound.Pause();  
        }
        else
        {
            SecurePlayerPrefs.SetString("IsSoundEffectsOn", "true", "password");
            SoundButton.GetComponent<Image>().sprite = sound_on;  
            themeSound.Play(); 
        }
    }
    

    public void PompaliTufek(){
        //coin yeterli mi
        
        string pompaliTufekUpgrade = SecurePlayerPrefs.GetString("PompaliTufekUpgrade", "password");
        bool parsepompaliTufekUpgrade = Int32.TryParse(pompaliTufekUpgrade, out int pompaliUp);

        string currentcoin = SecurePlayerPrefs.GetString("CurrentCoin", "password");
        bool parsecurrentCoin = Int32.TryParse(currentcoin, out int currentCoin);

        if (currentCoin > pompaliUp)
        {
            currentCoin -= pompaliUp;

            SecurePlayerPrefs.SetString("CurrentCoin", currentCoin.ToString(), "password");

            pompaliUp = pompaliUp * 2;

            SecurePlayerPrefs.SetString("PompaliTufekUpgrade", pompaliUp.ToString(), "password");

            string level = SecurePlayerPrefs.GetString("PompaliTufek","password");
            bool parselevel=Int32.TryParse(level, out int levelInt);

            levelInt++;

            SecurePlayerPrefs.SetString("PompaliTufek",levelInt.ToString() , "password");
        
            for ( int i = 0; i < levelInt; i++)
            {
             pompaliTufek[i].SetActive(true);
            }
        }

     
             }

 public void Kilic() 
        {
        string kilicUpgrade = SecurePlayerPrefs.GetString("KilicUpgrade", "password");
        bool parsekilicUpgrade = Int32.TryParse(kilicUpgrade, out int kilicUp);

        string currentcoin = SecurePlayerPrefs.GetString("CurrentCoin", "password");
        bool parsecurrentCoin = Int32.TryParse(currentcoin, out int currentCoin);

        if (currentCoin > kilicUp)
        {
         
            currentCoin -= kilicUp;

            SecurePlayerPrefs.SetString("CurrentCoin", currentCoin.ToString(), "password");

            kilicUp = kilicUp * 2;

            SecurePlayerPrefs.SetString("KilicUpgrade", kilicUp.ToString(), "password");

            string level = SecurePlayerPrefs.GetString("Kilic","password");
            bool parselevel=Int32.TryParse(level, out int levelInt);

            levelInt++;
            
            SecurePlayerPrefs.SetString("Kilic", levelInt.ToString() , "password");
        
                for ( Int32 i = 0; i < levelInt; i++)
                {
                kilic[i].SetActive(true);
                }
        }
             }

 public void Levye(){
            string levyeUpgrade = SecurePlayerPrefs.GetString("LevyeUpgrade", "password");
            bool parselevyeUpgrade=Int32.TryParse(levyeUpgrade, out int levyeUp);

            string currentcoin = SecurePlayerPrefs.GetString("CurrentCoin", "password");
            bool parsecurrentCoin = Int32.TryParse(currentcoin, out int currentCoin);

            if(currentCoin > levyeUp){
                currentCoin -= levyeUp;

                SecurePlayerPrefs.SetString("CurrentCoin", currentcoin.ToString(), "password");

                levyeUp = levyeUp * 2;

                SecurePlayerPrefs.SetString("LevyeUpgrade",levyeUp.ToString() , "password");

                string level = SecurePlayerPrefs.GetString("Levye","password");
                bool parselevel=Int32.TryParse(level, out int levelInt);

                levelInt++;
            
                SecurePlayerPrefs.SetString("Levye", levelInt.ToString() , "password");
        
                for (Int32 i = 0; i < levelInt; i++)
                {
                levye[i].SetActive(true);
                }

            }
        }
 public void NinjaYildizi(){
            string ninjaYildiziUpgrade = SecurePlayerPrefs.GetString("NinjaYildiziUpgrade", "password");
            bool parselevyeUpgrade=Int32.TryParse(ninjaYildiziUpgrade, out int ninjaUp);

            string currentcoin = SecurePlayerPrefs.GetString("CurrentCoin", "password");
            bool parsecurrentCoin = Int32.TryParse(currentcoin, out int currentCoin);

            if(currentCoin > ninjaUp){
                currentCoin -= ninjaUp;

                SecurePlayerPrefs.SetString("CurrentCoin", currentcoin.ToString(), "password");

                ninjaUp = ninjaUp * 2;

                SecurePlayerPrefs.SetString("NinjaYildiziUpgrade",ninjaUp.ToString() , "password");

                string level = SecurePlayerPrefs.GetString("NinjaYildizi","password");
                bool parselevel=Int32.TryParse(level, out int levelInt);

                levelInt++;
            
                SecurePlayerPrefs.SetString("NinjaYildizi", levelInt.ToString() , "password");
        
                for (Int32 i = 0; i < levelInt; i++)
                {
                ninjaYildizi[i].SetActive(true);
                }

            }

    } 
}
  





