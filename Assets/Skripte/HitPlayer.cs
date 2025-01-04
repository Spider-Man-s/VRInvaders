using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitPlayer : MonoBehaviour
{
    private Animator monsterAnimator;
    public Slider playerHp;

    private void Start()
    {
        // This will fetch the Animator from the same GameObject 
        // that this script is attached to
        monsterAnimator = GetComponent<Animator>();
    }

    public void Hit()
    {
        // Trigger the animator once
        monsterAnimator.SetTrigger("endOfLine");

        // Start the coroutine that deals damage over time
        StartCoroutine(DamageOverTime());
    }

    private IEnumerator DamageOverTime()
    {
        // While the slider has health above 0
        while (playerHp.value > 0)
        {
            // Wait 2 seconds between each damage tick
            yield return new WaitForSeconds(1.9f);

            if (GameSettings.currentDifficulty == GameSettings.Difficulty.Easy)
            {
                playerHp.value -= 0.1f;
            }
            else if (GameSettings.currentDifficulty == GameSettings.Difficulty.Medium)
            {
                playerHp.value -= 0.15f;
            }
            else if (GameSettings.currentDifficulty == GameSettings.Difficulty.Hard)
            {
                playerHp.value -= 0.2f;
            }
        }

        // Once the loop finishes, HP is <= 0. You can do "death" logic here if needed.

    }
}
