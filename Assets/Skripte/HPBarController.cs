using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BNG
{
    public class HPBarController : MonoBehaviour
    {

        public Damageable damageable;
        public UnityEngine.UI.Slider hpSlider;

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

        }

        private void Update()
        {
            float currentHP = damageable.Health;
            float hpPercent = currentHP / maxHP;
            hpPercent = Mathf.Clamp01(hpPercent);
            hpSlider.value = hpPercent;
        }
    }
}