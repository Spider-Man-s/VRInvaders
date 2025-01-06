using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HitPlayer : MonoBehaviour
{
    private Animator monsterAnimator;
    public Slider playerHp;

    private void Start()
    {

        monsterAnimator = GetComponent<Animator>();
    }

    public void Hit()
    {

        monsterAnimator.SetTrigger("endOfLine");

        StartCoroutine(DamageOverTime());
    }

    private IEnumerator DamageOverTime()
    {

        while (playerHp.value > 0)
        {

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

        GameSettings.PlayerDeath = true;
        SceneManager.LoadScene("EndScene", LoadSceneMode.Single);

    }
}
