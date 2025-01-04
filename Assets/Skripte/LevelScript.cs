using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerUIManager : MonoBehaviour
{

    [SerializeField] private Text playerNameText;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text timerText;


    private Slider hpSlider;
    private float maxHP = 100f;
    private float currentHP = 100f;



    public Coroutine timerCoroutine;

    public void Start()
    {

        playerNameText.text = "Player: " + GameSettings.Username;
        scoreText.text = "Score: " + GameSettings.Score.ToString();

        if (GameSettings.currentDifficulty == GameSettings.Difficulty.Easy)
        {
            timerCoroutine = StartCoroutine(TimerCoroutine(60f));
        }
        else if (GameSettings.currentDifficulty == GameSettings.Difficulty.Medium)
        {
            timerCoroutine = StartCoroutine(TimerCoroutine(120f));
        }
        else if (GameSettings.currentDifficulty == GameSettings.Difficulty.Hard)
        {
            timerCoroutine = StartCoroutine(TimerCoroutine(180f));
        }

    }

    public void Update()
    {
        scoreText.text = "Score: " + GameSettings.Score.ToString();
    }


    public IEnumerator TimerCoroutine(float time)
    {
        float countdown = time;
        while (countdown > 0)
        {
            countdown -= Time.deltaTime;
            UpdateTimerDisplay(countdown);
            yield return null;
        }
        UpdateTimerDisplay(0);

    }
    private void UpdateTimerDisplay(float timeRemaining)
    {
        int minutes = Mathf.FloorToInt(timeRemaining / 60f);
        int seconds = Mathf.FloorToInt(timeRemaining % 60f);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
