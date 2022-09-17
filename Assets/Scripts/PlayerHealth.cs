using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public static event Action OnPlayerDeath;
    public float health, maxHealth;

    public Slider slider;

    private void Start()
    {
        health = maxHealth;
    }
    
    public void TakeDamage(float amount)
    {
        health -= amount;
        slider.GetComponent<Slider>().value= health;
        
        if (health <= 0){
            health = 0;
            OnPlayerDeath?.Invoke();
        }
    }
}
