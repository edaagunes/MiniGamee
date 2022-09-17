using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    	
    public UnityEngine.UI.Button PauseButonu;

    public void ButonGizle(){
        PauseButonu.gameObject.SetActive(false);
    }
  
    public void Paused(){
        pauseMenu.SetActive(true);
        Time.timeScale=0f;

    }

    public void Resume(){
        pauseMenu.SetActive(false);
        Time.timeScale=1f;
    }

   public void MainMenuTurn(){
        SceneManager.LoadScene(0);
    }

    public void SettingsTurn(){

    }

}

