using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//UI for the healthbar max value is set to 100
//Script handles setting up, updating and subtracting health
public class HealthBar : MonoBehaviour
{
    [SerializeField]
    Slider healthSlider;

    int innitialHP = 100;

    private void Awake()
    {
        SetMaxHealth(innitialHP);
    }

    public void SetMaxHealth(int startingHealth)
    {
        healthSlider.maxValue = startingHealth;
        healthSlider.value = startingHealth;
    }

    public void UpdateHealth(int currentHealth)
    {
        healthSlider.value = currentHealth;
    }

    public void TakeDamage(int damage)
    {
        int remaindingHP = ((int)healthSlider.value);
        remaindingHP -= damage;

        UpdateHealth(remaindingHP);
    }

}
