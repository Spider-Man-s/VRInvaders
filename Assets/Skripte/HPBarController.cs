using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BNG
{
    public class HPBarController : MonoBehaviour
    {

        public Damageable damageable;  // Reference to your Damagable script
        public UnityEngine.UI.Slider hpSlider;
        // Reference to the UI Slider
        private float maxHP;

        private void Start()
        {
            if (GameSettings.currentDifficulty == GameSettings.Difficulty.Easy)
            {
                damageable.Health = 100;
                damageable._startingHealth = 100;
                maxHP = 100;
            }
            else if (GameSettings.currentDifficulty == GameSettings.Difficulty.Medium)
            {
                damageable.Health = 150;
                damageable._startingHealth = 150;
                maxHP = 150;
            }
            else if (GameSettings.currentDifficulty == GameSettings.Difficulty.Hard)
            {
                damageable.Health = 200;
                damageable._startingHealth = 200;
                maxHP = 200;
            }
            // maxHP = damageable._startingHealth;
        }

        private void Update()
        {
            // Get current and max HP from Damagable
            float currentHP = damageable.Health;
            // float maxHP = damageable._startingHealth;

            // Calculate the percentage (range 0 to 1)
            float hpPercent = currentHP / maxHP;

            // Clamp the percentage to avoid any potential out-of-range errors
            hpPercent = Mathf.Clamp01(hpPercent);

            // Set the Slider value
            hpSlider.value = hpPercent;
        }
    }
}