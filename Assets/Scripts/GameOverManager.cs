using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverScreen;

    private void OnEnable(){
        PlayerHealth.OnPlayerDeath += EnableGameOverMenu;
    }

     private void OnDisable(){
        PlayerHealth.OnPlayerDeath -= EnableGameOverMenu;
    }

    public void EnableGameOverMenu(){
        gameOverScreen.SetActive(true);
    }

    public void MainMenu(){
        SceneManager.LoadScene(0);
    }
    
    public void GameScene(){
        SceneManager.LoadScene(1);
    }
}
